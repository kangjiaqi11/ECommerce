create database ECommerce
use ECommerce
-----------------------------------康家齐-------------------------------------------
create table "User" (
   UserId               bigint               identity,
   UserName             varchar(50)          null,
   UserAccount          varbinary(50)        null,
   Salt                 varbinary(20)        null,
   UserPhoto            varchar(11)          null,
   UserAge              bigint               null,
   DepartmentId         int                  null,
   state                varchar(50)          null,
   CeateTime            datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   RoleId               int                  null,
   constraint PK_USER primary key (UserId)
)
go

create table Department (
   DepartmentId         bigint               identity,
   DepartmentName       varchar(50)          null,
   State                int                  not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   constraint PK_DEPARTMENT primary key (DepartmentId)
)
go
create table Role (
   RoleId               bigint               identity,
   RoleName             varbinary(50)        null,
   State                int                  not null,
   UpdateTime           datetime             not null,
   CreateTime           datetime             not null,
   UpdateId             bigint               not null,
   CreateId             bigint               not null,
   Visit                int                  null,
   constraint PK_ROLE primary key (RoleId)
)
go
create table Menus (
   MenusId              bigint               identity,
   MenusName            varchar(50)          null,
   MenusUrl             varbinary(100)       null,
   Statel               int                  not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   FatherUrl            varchar(50)          not null,
   constraint PK_MENUS primary key (MenusId)
)
go
create table Jurisdiction (
   JurisdictionId       bigint               identity,
   DepartmentId         bigint               null,
   MenusId              bigint               null,
   Statel               int                  not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateID             bigint               not null,
   constraint PK_JURISDICTION primary key (JurisdictionId)
)
go
create table Activity (
   ActivityId           bigint               identity,
   ActivityTitle        varchar(1000)        null,
   ActivityStatel       int                  null,
   TimeQId              bigint               null,
   GoodId               bigint               null,
   Statel               int                  null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   constraint PK_ACTIVITY primary key (ActivityId)
)
go
create table TimeQ (
   TimeQId              bigint               identity,
   TimeQName            varbinary(50)        null,
   StartTime            datetime             null,
   EenTime              datetime             null,
   Statel               int                  not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   constraint PK_TIMEQ primary key (TimeQId)
)
go
create table Recommend (
   RecommendId          bigint               identity,
   GoodId               bigint               null,
   IsRecommend          int                  null,
   State                int                  not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   constraint PK_RECOMMEND primary key (RecommendId)
)
go

--------------------------------------------------------------------------------------


-----------------------------------------张扬--------------------------------------

create table Shipping (
   ShippingId           bigint               identity,
   Photo                varchar(11)          null,
   Consignee            varchar(50)          null,
   Email                varchar(50)          null,
   Address              varchar(50)          null,
   State                varchar(50)          not null,
   UpdateTime           datetime             not null,
   CreateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   province             int                  null,
   City                 int                  null,
   District             int                  null,
   constraint PK_SHIPPING primary key (ShippingId)
)
go

create table FrontUser (
   FrontUserid          bigint               identity,
   Account              varchar(50)          null,
   UserPwd              varchar(50)          null,
   UserName             varchar(50)          null,
   MembersId            varchar(50)          null,
   Consumption          varchar(50)          null,
   Number               bigint               null,
   professional         varchar(50)          null,
   Age                  varchar(50)          null,
   city                 varchar(50)          null,
   Baddy                varchar(50)          null,
   classification       varchar(50)          null,
   Grqm                 varchar(50)          null,
   Sppj                 varchar(50)          null,
   Gz                   varchar(50)          null,
   Fs                   varchar(50)          null,
   Sc                   varchar(50)          null,
   Thjl                 varchar(50)          null,
   Czz                  bigint               null,
   Yhj                  varchar(50)          null,
   Scht                 varchar(50)          null,
   Ddid                 bigint               null,
   ShdzId               bigint               null,
   State                int                  not null,
   CTime                datetime             not null,
   XTime                datetime             not null,
   Modifier             bigint               not null,
   Founder              bigint               not null,
   constraint PK_FRONTUSER primary key (FrontUserid)
)
go
create table Storeroom (
   CkId                 bigint               identity,
   Spzp                 varchar(50)          null,
   ShoopName            varchar(50)          null,
   Hhsx                 varchar(50)          null,
   Ddh                  bigint               null,
   Kcsl                 varchar(50)          null,
   Kclx                 varchar(50)          null,
   State                int                  not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   constraint PK_STOREROOM primary key (CkId)
)
go
create table Member (
   MembersId            bigint               identity,
   members              varchar(50)          null,
   Growth               varchar(50)          null,
   Evaluation           varchar(50)          null,
   Freight              varchar(50)          null,
   Note                 varchar(50)          null,
   State                varchar(50)          not null,
   CTime                varchar(50)          not null,
   XTime                varchar(50)          not null,
   Founder              bigint               not null,
   UpdateId             bigint               not null,
   constraint PK_MEMBER primary key (MembersId)
)
go
create table Provinces (
   ProvincesId          bigint               identity,
   ProvincesName        varbinary(50)        null,
   ProvincesUpOne       bigint               null,
   constraint PK_PROVINCES primary key (ProvincesId)
)
go
--------------------------------------------------------------------------------------


--------------------------------------------徐亚东---------------------------------------
create table express (
   expressId            int                  identity,
   expressName          varchar(50)          null,
   expressState         int                  null,
   State                int                  not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   constraint PK_EXPRESS primary key (expressId)
)
go
create table SalesReturn (
   ReturnId             int                  identity,
   ReturnNumber         varchar(50)          null,
   ReturnState          int                  null,
   OrderId              int                  null,
   ReturmTime           datetime             null,
   ReturmRemark         varchar(50)          null,
   Remark               varchar(Max)         null,
   picture              varchar(50)          null,
   freightMoney         int                  null,
   consigneeName        varchar(50)          null,
   province             int                  null,
   City                 int                  null,
   district             int                  null,
   address              varchar(50)          null,
   PersonPhone          varchar(50)          null,
   comment              varchar(Max)         null,
   State                int                  not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   constraint PK_SALESRETURN primary key (ReturnId)
)
go
create table result (
   ReturnId             int                  identity,
   disposeName          varchar(50)          null,
   disposeTime          datetime             null,
   disposeRemark        varchar(Max)         null,
   State                int                  not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   constraint PK_RESULT primary key (ReturnId)
)
go
create table invoice (
   OrderId              int                  not null,
   InvoiceType          int                  null,
   InvoiceHead          varchar(50)          null,
   Invoicecontent       varchar(Max)         null,
   PersonName           varchar(50)          null,
   State                int                  not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
  
)
go

create table OrderTable (
   OrderId              bigint               identity,
   OrderNumber          varchar(50)          null,
   FrontUserid          bigint               null,
   OrderMoney           decimal              null,
   invoice              int                  null,
   payment              varchar(50)          null,
   Ordersource          varchar(50)          null,
   expressId            int                  null,
   expressNumber        varchar(50)          null,
   Growthvalue          int                  null,
   TakeGoods            int                  null,
   Activity             varchar(50)          null,
   GoodId               int                  null,
   MoneyId              int                  null,
   Oderstate            int                  null,
   SubmitTime           datetime             not null,
   EditTime             datetime             not null,
   CreatId              bigint               not null,
   EditId               bigint               not null,
   constraint PK_ORDERTABLE primary key (OrderId)
)
go

create table Invoicetype (
   InvoicetypeId        int                  identity,
   InvoieTypeName       varchar(50)          null,
   State                int                  not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   constraint PK_INVOICETYPE primary key (InvoicetypeId)
)
go
create table RetutnType (
   Id                   int                  identity,
   ReturnName           varchar(50)          null,
   RetuemState          int                  null,
   CreateTimes          datetime             null,
   State                int                  not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   constraint PK_RETUTNTYPE primary key (Id)
)
go

--------------------------------------------------------------------------------------


-----------------------------------------------汪志昊------------------------------------

create table GoodsInfo (
   GoodId               int                  identity,
   BrandId              int                  null,
   CategoryId           int                  null,
   GoodsType            int                  null,
   GoodsName            varchar(100)         null,
   GoodsBrief           varchar(max)         null,
   GoodsIntro           varchar(max)         null,
   MarketPrice          decimal(18,2)        null,
   SalePrice            decimal(18,2)        null,
   CostPrice            decimal(18,2)        null,
   BrowseCount          int                  null,
   CommentCount         int                  null,
   CollectCount         int                  null,
   ShareCount           int                  null,
   PutawayTime          DateTime             null,
   GoodsState           int                  null,
   Status               int                  not null,
   CreateTime           DateTime             not null,
   UpdateTime           DateTime             not null,
   CreaterId            bigint               not null,
   UpdaterId            bigint               not null,
   constraint PK_GOODSINFO primary key (GoodId)
)
go
create table BrandInfo (
   DrandId              int                  identity,
   BrandName            varchar(100)         null,
   State                int                  not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   constraint PK_BRANDINFO primary key (DrandId)
)
go
create table CommodityType (
   TypeId               int                  identity,
   TypeName             varchar(100)         null,
   State                int                  not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   constraint PK_COMMODITYTYPE primary key (TypeId)
)
go
create table EstimateInfo (
   EstimateId           bigint               identity,
   FrontUserid          bigint               null,
   CommodityId          int                  null,
   EstimateState        int                  null,
   EstimateContent      varchar(100)         null,
   State                int                  not null,
   CreateTime           datetime             not null,
   UpdateTime           datetime             not null,
   CreateId             bigint               not null,
   UpdateId             bigint               not null,
   constraint PK_ESTIMATEINFO primary key (EstimateId)
)
go

--------------------------------------------------------------------------------------

declare @count int;
exec P_good 0,'',1,5,@count out
select @count;

create proc P_good
@id int,
@goodsrname varchar(100),
@pageindex int,
@pagesize int,
@totalcount int out
as
begin
	declare @start int;
	declare @end int;

	set @start=(@pageindex-1)*@pagesize;
	set @end=@start+@pagesize;
	set @start=@start+1;

	declare @wheresql nvarchar(500);
	set @wheresql='where 1=1';

	if @id>0
	begin
		set @wheresql=@wheresql+'and id='+CONVERT(nvarchar,@id);
	end

	if LEN(@goodsrname)>0
	begin
		set @wheresql=@wheresql+'and name like ''%'+@goodsrname+'%''';
	end

	declare @selectsql nvarchar(500);
	set @selectsql='select * from (
	select ROW_NUMBER() over (order by id)as rowid,*from GoodsInfo'+@wheresql+'
	) as t where t.rowid between'+CONVERT(nvarchar,@start)+' and '+CONVERT(nvarchar,@end);

	declare @countsql nvarchar(500);
	set @countsql='select @totalcount=count(1) from GoodsInfo'+@wheresql;

	--执行查询语句
exec (@selectsql);
 exec sp_executesql @countsql,N' @totalcount int out ',@totalcount out;
end