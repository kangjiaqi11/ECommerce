declare @count int;
exec p_user 0,'',1,5,@count out
select @count;

alter proc p_user
@id int,
@username varchar(50),
@pageindex int,
@pagesize int,
@totalcount int out
as
begin
----------------------1.�����ѯ���ݵĿ�ʼ������ -----------------------------
	declare @start int;
	declare @end int;
	
	set @start=(@pageindex-1)*@pagesize;
	set @end=@start+@pagesize;
	set @start=@start+1;
	
----------------------2.ƴ�Ӳ�ѯ���� -----------------------------	
	declare @wheresql nvarchar(500);
	set @wheresql=' where 1=1 ';
	
	if @id>0
	begin
		set @wheresql=@wheresql+' and id= '+ CONVERT(nvarchar, @id );
	end

	if LEN(@username)>0
	begin
		set @wheresql=@wheresql+' and name  like ''%'+@username+'%''';
	end

----------------------3.��ʼƴ�ӷ�ҳ��ѯ��� -----------------------------
	declare @selectsql nvarchar(500); --ע�� �˴���ҪΪnvarchar��int���� ת��Ϊnvarchar����
	set @selectsql =' 	select * from ( 
	select ROW_NUMBER() over( order by id  ) as rowid,* from UserInfo'+ @wheresql+'
	)  as t where t.rowid between '+CONVERT(nvarchar,@start )+' and '+CONVERT(nvarchar, @end);
	
----------------------4.��ʼƴ�Ӳ�ѯ������-----------------------------
	declare @countsql nvarchar(500);--ע�� �˴���ҪΪnvarchar
	set @countsql ='select @totalcount=count(1)  from UserInfo'+ @wheresql;
----------------------5.ִ�����-----------------------------
--ִ�в�ѯ���
exec (@selectsql);
 exec sp_executesql @countsql,N' @totalcount int out ',@totalcount out;
end