USE [HTBook]
GO
/****** Object:  UserDefinedTableType [dbo].[ins_InwardDetails]    Script Date: 21/05/2017 9:18:43 PM ******/
CREATE TYPE [dbo].[ins_InwardDetails] AS TABLE(
	[InwardDetailId] [int] NULL,
	[InwardId] [int] NULL,
	[ItemId] [int] NULL,
	[CapitalA] [nvarchar](5) NULL,
	[Digital1] [int] NULL,
	[smalla] [nvarchar](50) NULL,
	[ItemRemark] [nvarchar](max) NULL,
	[Unit] [nvarchar](50) NULL,
	[Qty] [money] NULL,
	[Rate] [money] NULL,
	[Amount] [money] NULL,
	[Vatper] [money] NULL,
	[VatAmount] [money] NULL,
	[Dis] [money] NULL,
	[DisAmount] [money] NULL
)
GO
/****** Object:  StoredProcedure [dbo].[Ins_Inward]    Script Date: 21/05/2017 9:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Ins_Inward]
@InwardID int,
@PartyId int,
@InwardDate datetime,
@CenterId int,
@BillNo varchar(50),
@Remark varchar(50),
@AmountAdd int,
@AmountLess int,
@Total Numeric(18,2),
@Paid int,
@PaidRemark varchar(50),
@OrderNo varchar(50),
@OrderDate datetime,
@ChallanNo varchar(50),
@ChallanDate datetime,
@LRNo varchar(50),
@LRDate datetime,
@VatPerFour numeric(18,2),
@VatFourAmont numeric(18,2),
@ATaxOne numeric(18,2),
@ATaxOneAmount numeric(18,2),
@VatPerTwelveFive numeric(18,2),
@VatPerTwelveFiveAmount numeric(18,2),
@ATaxTwoFive numeric(18,2),
@ATaxTwoFiveAmount numeric(18,2),
@TotalAmont numeric(18,2),
@DisFive numeric(18,2),
@DisFiveAmount numeric(18,2),
@NetAmont numeric(18,2),
@CstTwoPer numeric(18,2),
@Roundoff numeric(18,2),
@DetailDiscount numeric(18,2),
@isQuatation bit,
@InvoiceType varchar(50),
@Action AS smallint,
@IwdDetails As ins_InwardDetails READONLY
AS
BEGIN
SET NOCOUNT ON;

IF @Action = 1 
	BEGIN
		INSERT INTO dbo.Inward
		(
			PartyId, InwardDate, BillNo, Remark, AmountAdd, AmountLess, Total, Paid, PaidRemark, OrderNo,
			OrderDate, ChallanNo, ChallanDate, LRNo, LRDate, VatPerFour, VatFourAmont, ATaxOne, ATaxOneAmount, 
			VatPerTwelveFive, VatPerTwelveFiveAmount, ATaxTwoFive, ATaxTwoFiveAmount, TotalAmont, DisFive, DisFiveAmount,
			NetAmont, CstTwoPer, Roundoff, DetailDiscount, isQuatation, InvoiceType
		)
		VALUES
		(
			@PartyId, @InwardDate, @BillNo, @Remark, @AmountAdd, @AmountLess, @Total, @Paid, @PaidRemark, @OrderNo,
			@OrderDate, @ChallanNo, @ChallanDate, @LRNo, @LRDate, @VatPerFour, @VatFourAmont, @ATaxOne, @ATaxOneAmount, 
			@VatPerTwelveFive, @VatPerTwelveFiveAmount, @ATaxTwoFive, @ATaxTwoFiveAmount, @TotalAmont, @DisFive, @DisFiveAmount,
			@NetAmont, @CstTwoPer, @Roundoff, @DetailDiscount, @isQuatation, @InvoiceType
		)
		SET @InwardID = SCOPE_IDENTITY ()
		
	INSERT into dbo.InwardDetail
	(
		InwardId, ItemId, CapitalA, Digital1, smalla, ItemRemark, 
		Unit, Qty, Rate, Amount, Vatper, VatAmount ,Dis, DisAmount  
	
	)
	SELECT 
		InwardId, ItemId, CapitalA, Digital1, smalla, ItemRemark, 
		Unit, Qty, Rate, Amount, Vatper, VatAmount ,Dis, DisAmount

	FROM @IwdDetails

	END

IF @Action = 2
	BEGIN
		UPDATE dbo.Inward SET
			PartyId = @PartyId, InwardDate = @InwardDate,  BillNo = @BillNo, Remark = @Remark, AmountAdd = @AmountAdd, 
			AmountLess = @AmountLess, Total = @Total, Paid = @Paid, PaidRemark = @PaidRemark, OrderNo = @OrderNo, OrderDate = @OrderDate, 
			ChallanNo = @ChallanNo, ChallanDate = @ChallanDate, LRNo = @LRNo, LRDate = @LRDate, VatPerFour = @VatPerFour, VatFourAmont = @VatFourAmont, 
			ATaxOne = @ATaxOne, ATaxOneAmount = @ATaxOneAmount,	VatPerTwelveFive = @VatPerTwelveFive, VatPerTwelveFiveAmount = @VatPerTwelveFiveAmount, 
			ATaxTwoFive = @ATaxTwoFive, ATaxTwoFiveAmount = @ATaxTwoFiveAmount, TotalAmont = @TotalAmont, DisFive = @DisFive, 
			DisFiveAmount = @DisFiveAmount, NetAmont = @NetAmont, CstTwoPer = @CstTwoPer, Roundoff = @Roundoff, 
			DetailDiscount = @DetailDiscount, isQuatation = @isQuatation, InvoiceType = @InvoiceType
		WHERE InwardId = @InwardID
	
	Delete From InwardDetail WHere InwardId = @InwardID 
	INSERT into dbo.InwardDetail
	(
		InwardId, ItemId, CapitalA, Digital1, smalla, ItemRemark, 
		Unit, Qty, Rate, Amount, Vatper, VatAmount ,Dis, DisAmount  
	
	)
	SELECT 
		InwardId, ItemId, CapitalA, Digital1, smalla, ItemRemark, 
		Unit, Qty, Rate, Amount, Vatper, VatAmount ,Dis, DisAmount

	FROM @IwdDetails

	END

END
GO
/****** Object:  StoredProcedure [dbo].[LIst_InwardDetails]    Script Date: 21/05/2017 9:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LIst_InwardDetails]
	@InwardId as int

AS
BEGIN
SET NOCOUNT ON;

	SELECT

		InwardId, PartyId, InwardDate, CenterId, BillNo, Remark, AmountAdd, AmountLess, Total,
		Paid, PaidRemark, OrderNo, OrderDate, ChallanNo, ChallanDate, LRNo, LRDate, VatPerFour,
		VatFourAmont, ATaxOne, ATaxOneAmount, VatPerTwelveFive, VatPerTwelveFiveAmount, ATaxTwoFive,
		ATaxTwoFiveAmount, TotalAmont, DisFive, DisFiveAmount, NetAmont, CstTwoPer, Roundoff, DetailDiscount,
		isQuatation, InvoiceType

	FROM dbo.inward
	WHERE InwardId = @InwardId 

	SELECT 
	
		InwardDetailId, InwardId, ItemId, CapitalA, Digital1, smalla, ItemRemark, Unit, Qty, Rate,
		Dis, DisAmount, Isnull(Vatper,0) As VatPer, VatAmount, Amount

	FROM InwardDetail 
	WHERE InwardId = @InwardId 

END

GO
/****** Object:  StoredProcedure [dbo].[View_Inward]    Script Date: 21/05/2017 9:18:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PRocedure [dbo].[View_Inward]
	@MyOPt as int,
	@InwardId as int,
	@IsQuatation as bit
AS 
BEGIN
SET NOCOUNT ON;
IF @MyOPt = 1 
	BEGIN
		select 
			 InwardId, BillNo As InvoiceNo, InvoiceType,InwardDate AS InvoiceDate,PartyName,
			 VatFourAmont AS Vat4, ATaxOneAmount As ATax1, VatPerTwelveFiveAmount As Vat125,
			 ATaxTwoFiveAmount AS ATax25, DetailDiscount as TaxDisCount,
			 DisFive as LaboutPer, DisFiveAmount as LabourDiscount, NetAmont As Amount


		 from Inward
		 left join PartyMaster on Inward .PartyId = PartyMaster.PartyId  
		 WHERE InwardId != 0 AND isQuatation = @IsQuatation
	END
ELSE IF @MyOPt = 2 
	BEGIN
		select 
			 Inward.*, PartyMaster .PartyName
		 from Inward
		 left join PartyMaster on Inward .PartyId = PartyMaster.PartyId  
		 WHERE InwardId = @InwardId AND isQuatation = @IsQuatation

		 SELECT 
	
		InwardDetailId, InwardId, ItemId, CapitalA, Digital1, smalla, ItemRemark, Unit, Qty, Rate,
		Dis, DisAmount, Isnull(Vatper,0) As VatPer, VatAmount, Amount

	FROM InwardDetail 
	WHERE InwardId = @InwardId 
	END
END 

GO
