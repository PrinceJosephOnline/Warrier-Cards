$(document).ready(function () {

    //$.removeCookie('wc_cart', { path: '/' });
    //$.removeCookie('wc_cart');
    //$.removeCookie('wc_shortlist', { path: '/' });
    //$.removeCookie('wc_shortlist');

    //alert($.cookie('wc_shortlist'));
    //LinkStyling();
    DisplayShortlistCountAndHighlight();
    DisplayCartCount();
    DisplayQuantityFromCart();
});

// To make non-anchor elements as link, href same as first anchor child
//function LinkStyling() {
//    $('.hover-link').each(function () {
//        var href = $(this).find('a:first').attr('href');
//        if (href != null) {
//            $(this).on('click', function () { window.location.href = href; });
//            $(this).on('mouseover', function () { window.status = href; return false; });
//        }
//    });
//}

function OnKeywordSearch(form) {
    var keyword = $(form).find('input[type=text]:first').val();
    keyword = $.trim(keyword).replace(/\s+/g, '-').toLowerCase();
    form.action = form.action + '/' + keyword;
}

ActionEnum = {
    add: 0,
    update: 1,
    remove: 2
}

// To display shortlisted icon for shortlisted cards
function DisplayShortlistCountAndHighlight() {
    if ($.cookie('wc_shortlist') == null) { return; }
    var cookieData = JSON.parse($.cookie('wc_shortlist'));
    // Display count in header
    var value = cookieData.length > 0 ? cookieData.length : '';
    $('.nav-shortlist').find('.sup').html(value);

    // Find shortlisted articles & tag them yellow 
    $.each(cookieData, function (i, obj) {
        if (obj == null) { return; }
        $('article[data-id=' + obj.CardId + ']').find('.shortlist').addClass('shortlisted');
    });

    //    var articles = $('article[data-id=' + obj.CardId + ']');
    //    // If an item is listed multiple times (say in multiple sections)
    //    $(articles).each(function () {
    //        $(this).find('.shortlist').addClass('shortlisted');
    //    });
    //});
}

// Display cart item count in header
function DisplayCartCount(count) {
    if (count == null) {
        if ($.cookie('wc_cart') != null) {
            var cookieData = JSON.parse($.cookie('wc_cart'));
            count = cookieData.length > 0 ? cookieData.length : '';
        }
    }
    count = count > 0 ? count : '';
    $('.nav-cart').find('.sup').html(count);
}

// If an item added to card is viewed, show the quanity from cart
function DisplayQuantityFromCart() {
    // if cookie is null or no quantity textbox
    if ($.cookie('wc_cart') == null) { return; }
    if ($('article').find('input[data-type="quantity"]') == null) { return; }
    var cookieData = JSON.parse($.cookie('wc_cart'));
    $.each(cookieData, function (i, obj) {
        var quantityInput = $('article[data-id="' + obj.CardId + '"]').find('input[data-type="quantity"]')
        if (quantityInput != null) { $(quantityInput).val(obj.Quantity); }
    });
}

function OnCardSelected(cardId, isShortlist, quantity, action) {
    if (typeof (isShortlist) === 'undefined') { isShortlist = true; }
    if (typeof (quantity) === 'undefined') { quantity = 250; }
    var cookieName = isShortlist ? 'wc_shortlist' : 'wc_cart';
    if ($.cookie(cookieName) == null) {
        $.cookie(cookieName, '[]', { expires: 20, path: '/' });
    }
    var cookieData = JSON.parse($.cookie(cookieName));
    // Remove the item if exist
    $.each(cookieData, function (i, obj) {
        if (obj != null && obj.CardId == cardId) {
            cookieData.splice(i, 1);
        }
    });
    // Add it back, for add/update request
    if (action == ActionEnum.add || action == ActionEnum.update) {
        var newItem = {
            'CardId': cardId,
            'Quantity': quantity
        };
        cookieData.push(newItem);
    }

    $.cookie(cookieName, JSON.stringify(cookieData), { path: '/' });
    // update the count display in header
    var value = cookieData.length > 0 ? cookieData.length : '';
    if (isShortlist) {
        $('.nav-shortlist').find('.sup').html(value);
        $('article[data-id=' + cardId + ']').find('.shortlist').addClass('shortlisted');
    } else {
        DisplayCartCount(value);
    }
}

function OnAddToCart(source) {
    var cardId = $(source).closest('article').data("id");
    if (cardId < 0) { alert('Sorry, an error occurred, please try again later'); return; }
    var quantity = $('article[data-id="' + cardId + '"]').find('input[data-type="quantity"]').val();
    if (quantity < 50) { alert('Minimum quantity required is 50'); return; }
    OnCardSelected(cardId, false, quantity, ActionEnum.add);
    QuickMessage(source, '1 item added to cart (Quantity: ' + quantity + ')');
}

function OnRemoveFromCart(source) {
    var cardId = $(source).closest('article').data("id");
    if (cardId < 0) { alert('Sorry, an error occurred, please try again later'); return; }
    OnCardSelected(cardId, false, 0, ActionEnum.remove);
}

function OnRemoveFromShortlist(source) {
    var cardId = $(source).closest('article').data("id");
    if (cardId < 0) { alert('Sorry, an error occurred, please try again later'); return; }
    OnCardSelected(cardId, true, 0, ActionEnum.remove);
}

function MoveToShortlist(source) {
    var article = $(source).closest('article');
    var cardId = $(article).data("id");
    if (cardId < 0) { alert('Sorry, an error occurred, please try again later'); return; }
    var quantity = $(article).find('input[data-type="quantity"]').val();
    OnCardSelected(cardId, false, quantity, ActionEnum.remove);
    OnCardSelected(cardId, true, quantity, ActionEnum.add);
}

function MoveToCart(source) {
    var article = $(source).closest('article');
    var cardId = $(article).data("id");
    if (cardId < 0) { alert('Sorry, an error occurred, please try again later'); return; }
    var quantity = $(article).find('input[data-type="quantity"]').val();
    OnCardSelected(cardId, true, quantity, ActionEnum.remove);
    OnCardSelected(cardId, false, quantity, ActionEnum.add);
}

function OnShortlist(source) {
    var cardId = $(source).closest('article').data("id");
    if (cardId < 0) { alert('Sorry, an error occurred, please try again later'); return; }
    var quantity = $('article[data-id="' + cardId + '"]').find('input[data-type="quantity"]').val();

    var isRemove = $(source).hasClass('shortlisted');
    if (isRemove) {
        OnCardSelected(cardId, true, quantity, ActionEnum.remove);
        $(source).removeClass('shortlisted');
    }
    else {
        OnCardSelected(cardId, true, quantity, ActionEnum.add);
        $(source).addClass('shortlisted');
    }
}

function OnBuySample(source) {
    var cardId = $(source).closest('article').data("id");
    if (cardId < 0) { alert('Sorry, an error occurred, please try again later'); return; }
    OnCardSelected(cardId, false, 1, ActionEnum.add);
    $('article[data-id="' + cardId + '"]').find('input[data-type="quantity"]').val(1);
    QuickMessage(source, '1 item added to Sample cart');
}
function BringImageIntoView(img) {
    var newSrc = $(img).attr('src');
    var mainImg = $(img).parent().parent().find('img').first();
    $(mainImg).attr('src', newSrc);
    $(img).siblings('img').removeClass('selected');
    $(img).addClass('selected');
}

function QuickView(cardId) {
    $.ajax({
        url: 'http://' + window.location.host + "/quick-view/" + cardId,
        success: function (result) {
            ShowDialog(result);
        }
    });
}

function QuickMessage(source, message) {
    var position = $(source).position();
    var y = position.top - $(window).scrollTop() - 10;
    var x = position.left - $(window).scrollLeft() + 10;
    var infoBox = $('#divQuickMessage');
    infoBox.html(message);
    infoBox.css({ 'display': 'block', 'top': y, 'left': x });
    infoBox.delay(1000).fadeOut('slow');
}

function ShowDialog(data) {
    var content = '<div class="modal-content">' +
    '<span onclick="Close();" class="close">x</span>' +
    '<div class="modal-main clear">' + data + '</div>'
    '</div>';
    $('#myModal').html(content);
    $('#myModal').css('display', 'block');
    $('.modal-content').width($('.modal-main div:first-child').width());
}

function Close() {
    $('#myModal').css('display', 'none')
}

function OnBuyNow(source) {
    var cardId = $(source).closest('article').data("id");
    if (cardId < 0) { alert('Sorry, an error occurred, please try again later'); return; }
    var quantity = $('article[data-id="' + cardId + '"]').find('input[data-type="quantity"]').val();
    quantity = quantity == 1 ? 250 : quantity;
    OnCardSelected(cardId, false, quantity, ActionEnum.add);

    alert('Buy now - View Cart - coming soon'); alert(window.location.host);
    window.location.href = 'http://' + window.location.host; // TODO: PRINCE - Go To Cart
}

function SendEnquiry(source)
{
    var cardId = $(source).closest('article').data("id");
    if (cardId < 0) { alert('Sorry, an error occurred, please try again later'); return; }
    $.ajax({
        url: 'http://' + window.location.host + "/send-enquiry/" + cardId,
        success: function (result) {
            ShowDialog(result);
        },
        failure: function (result) {
            alert(result);
        }
    });
}