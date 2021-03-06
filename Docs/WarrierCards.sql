USE [WarrierCards]
GO
/****** Object:  Table [dbo].[accounting]    Script Date: 08/20/2016 18:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accounting](
	[accounting_id] [bigint] NOT NULL,
	[particulars] [nchar](200) NOT NULL,
	[amount] [decimal](9, 2) NOT NULL,
	[is_debit] [bit] NOT NULL,
	[description] [nchar](800) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suppliers]    Script Date: 08/20/2016 18:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suppliers](
	[supplier_id] [bigint] IDENTITY(1,1) NOT NULL,
	[supplier_name] [nchar](200) NOT NULL,
	[supplier_address] [nchar](200) NULL,
	[supplier_district] [nchar](20) NULL,
	[supplier_state] [nchar](20) NULL,
	[supplier_country] [nchar](20) NULL,
	[supplier_pincode] [nchar](10) NULL,
	[supplier_email] [nchar](200) NULL,
	[supplier_phone1] [nchar](12) NULL,
	[supplier_phone2] [nchar](12) NULL,
	[supplier_website] [nchar](10) NULL,
	[details] [nchar](200) NULL,
 CONSTRAINT [PK_suppliers] PRIMARY KEY CLUSTERED 
(
	[supplier_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 08/20/2016 18:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [bigint] IDENTITY(1,1) NOT NULL,
	[first_name] [nchar](20) NULL,
	[last_name] [nchar](20) NULL,
	[password] [nvarchar](100) NOT NULL,
	[email_id] [nvarchar](200) NOT NULL,
	[phone] [numeric](11, 0) NOT NULL,
	[registered_date] [datetime] NOT NULL,
	[last_login_date] [datetime] NULL,
	[is_active] [bit] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[shipping_addresses]    Script Date: 08/20/2016 18:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[shipping_addresses](
	[address_id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[full_address] [nvarchar](max) NULL,
	[pincode] [nvarchar](50) NULL,
	[landmark] [nvarchar](200) NULL,
	[country] [nvarchar](50) NULL,
	[mobile] [numeric](12, 0) NULL,
	[user_id] [bigint] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[address_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sellers]    Script Date: 08/20/2016 18:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sellers](
	[user_id] [bigint] NOT NULL,
	[address] [nchar](200) NULL,
	[district] [nchar](20) NULL,
	[state] [nchar](20) NULL,
	[country] [nchar](20) NULL,
	[pincode] [nchar](10) NULL,
	[phone2] [nchar](12) NULL,
	[website] [nchar](10) NULL,
	[fee_percentage] [int] NOT NULL,
	[account_number] [nchar](10) NULL,
	[account_type] [nchar](10) NULL,
	[transaction_profile_id] [nchar](50) NULL,
 CONSTRAINT [PK_sellers_1] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[testimonials]    Script Date: 08/20/2016 18:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[testimonials](
	[testimonial_id] [bigint] IDENTITY(1,1) NOT NULL,
	[user_id] [bigint] NULL,
	[comments] [nvarchar](max) NULL,
	[rating] [int] NULL,
 CONSTRAINT [PK_tstimonials] PRIMARY KEY CLUSTERED 
(
	[testimonial_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cards]    Script Date: 08/20/2016 18:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cards](
	[card_id] [bigint] IDENTITY(1,1) NOT NULL,
	[card_name] [nvarchar](50) NOT NULL,
	[model_number] [nvarchar](50) NOT NULL,
	[supplier_id] [bigint] NOT NULL,
	[seller_id] [bigint] NULL,
	[weight] [numeric](18, 0) NOT NULL,
	[dimension] [nvarchar](50) NOT NULL,
	[type] [bit] NOT NULL,
	[orientation] [bit] NOT NULL,
	[printing_option] [nvarchar](100) NOT NULL,
	[color] [nvarchar](200) NOT NULL,
	[gsm] [int] NOT NULL,
	[original_price] [decimal](9, 2) NOT NULL,
	[selling_price] [decimal](9, 2) NOT NULL,
	[description] [nvarchar](2000) NULL,
	[available_quantity] [bigint] NOT NULL,
	[keywords] [nvarchar](2000) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_card_details] PRIMARY KEY CLUSTERED 
(
	[card_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[shopping_cart]    Script Date: 08/20/2016 18:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[shopping_cart](
	[cart_id] [bigint] IDENTITY(1,1) NOT NULL,
	[user_id] [bigint] NOT NULL,
	[card_id] [bigint] NOT NULL,
	[quantity] [int] NOT NULL,
	[is_shortlist_only] [bit] NOT NULL,
	[added_datetime] [datetime] NOT NULL,
 CONSTRAINT [PK_shopping_cart] PRIMARY KEY CLUSTERED 
(
	[cart_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'True->original cart, False->added to shortlist' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'shopping_cart', @level2type=N'COLUMN',@level2name=N'is_shortlist_only'
GO
/****** Object:  Table [dbo].[orders]    Script Date: 08/20/2016 18:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[order_id] [bigint] NOT NULL,
	[user_id] [bigint] NOT NULL,
	[card_id] [bigint] NOT NULL,
	[quantity] [int] NOT NULL,
	[address_id] [bigint] NOT NULL,
	[is_print_requested] [bit] NULL,
	[total_amount] [bigint] NULL,
	[payment_status] [bit] NOT NULL,
	[payment_mode] [bit] NULL,
	[payment_txn_id] [nchar](80) NULL,
	[is_samplekit] [bit] NOT NULL,
 CONSTRAINT [PK_order_details] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[seller_payments]    Script Date: 08/20/2016 18:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[seller_payments](
	[transaction_id] [bigint] NOT NULL,
	[seller_id] [bigint] IDENTITY(1,1) NOT NULL,
	[order_id] [bigint] NULL,
	[invoice_id] [nchar](20) NULL,
	[total_amount] [decimal](9, 2) NOT NULL,
	[seller_fee_amount] [decimal](9, 2) NOT NULL,
	[seller_fee_criteria] [nchar](100) NOT NULL,
	[transaction_date] [datetime] NOT NULL,
	[author_id] [bigint] NOT NULL,
	[details] [nchar](200) NULL,
 CONSTRAINT [PK_seller_payments] PRIMARY KEY CLUSTERED 
(
	[transaction_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_management]    Script Date: 08/20/2016 18:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_management](
	[activity_id] [bigint] IDENTITY(1,1) NOT NULL,
	[order_id] [bigint] NOT NULL,
	[author_id] [bigint] NOT NULL,
	[activity] [tinyint] NOT NULL,
	[details] [nchar](1000) NULL,
	[activity_date] [datetime] NOT NULL,
	[activity_ip] [nchar](30) NULL,
	[is_moble_device] [bit] NOT NULL,
	[user_agent] [nchar](10) NULL,
 CONSTRAINT [PK_order_management] PRIMARY KEY CLUSTERED 
(
	[activity_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_customization]    Script Date: 08/20/2016 18:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_customization](
	[customization_id] [bigint] IDENTITY(1,1) NOT NULL,
	[order_id] [bigint] NOT NULL,
	[content_type] [tinyint] NOT NULL,
	[custom_content] [nchar](4000) NOT NULL,
 CONSTRAINT [PK_order_customization_1] PRIMARY KEY CLUSTERED 
(
	[customization_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Text, Image, Doc, pdf, psd' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'order_customization', @level2type=N'COLUMN',@level2name=N'content_type'
GO
/****** Object:  Default [DF_Table_1_is_credit]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[accounting] ADD  CONSTRAINT [DF_Table_1_is_credit]  DEFAULT ((1)) FOR [is_debit]
GO
/****** Object:  Default [DF_users_is_active]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_is_active]  DEFAULT ((1)) FOR [is_active]
GO
/****** Object:  Default [DF_sellers_seller_fee_percentage]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[sellers] ADD  CONSTRAINT [DF_sellers_seller_fee_percentage]  DEFAULT ((2)) FOR [fee_percentage]
GO
/****** Object:  Default [DF_cards_is_active]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[cards] ADD  CONSTRAINT [DF_cards_is_active]  DEFAULT ((1)) FOR [keywords]
GO
/****** Object:  Default [DF_shopping_cart_is_shortlist_only]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[shopping_cart] ADD  CONSTRAINT [DF_shopping_cart_is_shortlist_only]  DEFAULT ((0)) FOR [is_shortlist_only]
GO
/****** Object:  Default [DF_orders_payment_status]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[orders] ADD  CONSTRAINT [DF_orders_payment_status]  DEFAULT ((0)) FOR [payment_status]
GO
/****** Object:  Default [DF_orders_is_samplekit]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[orders] ADD  CONSTRAINT [DF_orders_is_samplekit]  DEFAULT ((0)) FOR [is_samplekit]
GO
/****** Object:  Default [DF_order_management_is_moble_device]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[order_management] ADD  CONSTRAINT [DF_order_management_is_moble_device]  DEFAULT ((0)) FOR [is_moble_device]
GO
/****** Object:  ForeignKey [FK_sellers_users]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[sellers]  WITH CHECK ADD  CONSTRAINT [FK_sellers_users] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sellers] CHECK CONSTRAINT [FK_sellers_users]
GO
/****** Object:  ForeignKey [FK_testimonials_users]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[testimonials]  WITH CHECK ADD  CONSTRAINT [FK_testimonials_users] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[testimonials] CHECK CONSTRAINT [FK_testimonials_users]
GO
/****** Object:  ForeignKey [FK_cards_sellers]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[cards]  WITH CHECK ADD  CONSTRAINT [FK_cards_sellers] FOREIGN KEY([seller_id])
REFERENCES [dbo].[sellers] ([user_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cards] CHECK CONSTRAINT [FK_cards_sellers]
GO
/****** Object:  ForeignKey [FK_cards_suppliers]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[cards]  WITH CHECK ADD  CONSTRAINT [FK_cards_suppliers] FOREIGN KEY([supplier_id])
REFERENCES [dbo].[suppliers] ([supplier_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cards] CHECK CONSTRAINT [FK_cards_suppliers]
GO
/****** Object:  ForeignKey [FK_shopping_cart_cards]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[shopping_cart]  WITH CHECK ADD  CONSTRAINT [FK_shopping_cart_cards] FOREIGN KEY([card_id])
REFERENCES [dbo].[cards] ([card_id])
GO
ALTER TABLE [dbo].[shopping_cart] CHECK CONSTRAINT [FK_shopping_cart_cards]
GO
/****** Object:  ForeignKey [FK_shopping_cart_users]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[shopping_cart]  WITH CHECK ADD  CONSTRAINT [FK_shopping_cart_users] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[shopping_cart] CHECK CONSTRAINT [FK_shopping_cart_users]
GO
/****** Object:  ForeignKey [FK_orders_cards]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_cards] FOREIGN KEY([card_id])
REFERENCES [dbo].[cards] ([card_id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_cards]
GO
/****** Object:  ForeignKey [FK_orders_shipping_addresses]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_shipping_addresses] FOREIGN KEY([address_id])
REFERENCES [dbo].[shipping_addresses] ([address_id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_shipping_addresses]
GO
/****** Object:  ForeignKey [FK_seller_payments_orders]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[seller_payments]  WITH CHECK ADD  CONSTRAINT [FK_seller_payments_orders] FOREIGN KEY([order_id])
REFERENCES [dbo].[orders] ([order_id])
GO
ALTER TABLE [dbo].[seller_payments] CHECK CONSTRAINT [FK_seller_payments_orders]
GO
/****** Object:  ForeignKey [FK_seller_payments_sellers]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[seller_payments]  WITH CHECK ADD  CONSTRAINT [FK_seller_payments_sellers] FOREIGN KEY([seller_id])
REFERENCES [dbo].[sellers] ([user_id])
GO
ALTER TABLE [dbo].[seller_payments] CHECK CONSTRAINT [FK_seller_payments_sellers]
GO
/****** Object:  ForeignKey [FK_order_management_orders]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[order_management]  WITH CHECK ADD  CONSTRAINT [FK_order_management_orders] FOREIGN KEY([order_id])
REFERENCES [dbo].[orders] ([order_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[order_management] CHECK CONSTRAINT [FK_order_management_orders]
GO
/****** Object:  ForeignKey [FK_order_management_users]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[order_management]  WITH CHECK ADD  CONSTRAINT [FK_order_management_users] FOREIGN KEY([author_id])
REFERENCES [dbo].[users] ([user_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[order_management] CHECK CONSTRAINT [FK_order_management_users]
GO
/****** Object:  ForeignKey [FK_order_customization_orders]    Script Date: 08/20/2016 18:11:42 ******/
ALTER TABLE [dbo].[order_customization]  WITH CHECK ADD  CONSTRAINT [FK_order_customization_orders] FOREIGN KEY([order_id])
REFERENCES [dbo].[orders] ([order_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[order_customization] CHECK CONSTRAINT [FK_order_customization_orders]
GO
