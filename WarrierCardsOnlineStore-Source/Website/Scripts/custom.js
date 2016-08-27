$(document).ready(function () {
    //LinkStyling();
    //$.removeCookie('wc_cart', { path: '/' });
    //$.removeCookie('wc_cart');
    //$.removeCookie('wc_cart', { path: '/' });
    //$.removeCookie('wc_cart');
    //alert($.cookie('wc_shortlist'));

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
        var articles = $('article[data-id=' + obj.id + ']');
        // If an item is listed multiple times (say in multiple sections)
        $(articles).each(function () {
            $(this).find('.shortlist').addClass('shortlisted');
        });
    });
}

// Display cart item count in header
function DisplayCartCount(count)
{
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
function DisplayQuantityFromCart()
{
    // if cookie is null or no quantity textbox
    if ($.cookie('wc_cart') == null || $('input[data-type=quantity]') == null) { return; }
    var cookieData = JSON.parse($.cookie('wc_cart'));
    $.each(cookieData, function (i, obj) {
        var quantityInput = $('input[data-id=' + obj.id + ']');
        if (quantityInput != null) { $(quantityInput).val(obj.quantity); }
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
        if (obj != null && obj.id == cardId) {
            cookieData.splice(i, 1);
        }
    });
    // Add it back, for add/update request
    if (action == ActionEnum.add || action == ActionEnum.update) {
        var newItem = {
            'id': cardId,
            'quantity': quantity
        };
        cookieData.push(newItem);
    }

    $.cookie(cookieName, JSON.stringify(cookieData), { path: '/' });
    // update the count display in header
    var value = cookieData.length > 0 ? cookieData.length : '';
    if (isShortlist) {
        $('.nav-shortlist').find('.sup').html(value);
    } else {
        DisplayCartCount(value);
    }

}

function OnAddToCart(cardId, quantity)
{
    alert('quantity: ' + quantity);
    OnCardSelected(cardId, false, quantity, ActionEnum.add);
}

function OnRemoveFromCart(cardId) {
    OnCardSelected(cardId, false, 0, ActionEnum.remove);
}

function OnShortlist(source, cardId, quantity) {
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

// TODO remove from shortlist / cart - PRINCE

// TODO: update quantity