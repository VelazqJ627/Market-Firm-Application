--------------------------------------------------------
--  File created - Thursday-December-07-2017   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table AspNetUsers
--------------------------------------------------------

  CREATE TABLE "SYSTEM"."AspNetUsers" 
   (	"Id" NVARCHAR2(128), 
	"Email" NVARCHAR2(256), 
	"EmailConfirmed" NUMBER(1,0), 
	"PasswordHash" NVARCHAR2(256), 
	"SecurityStamp" NVARCHAR2(256), 
	"PhoneNumber" NVARCHAR2(256), 
	"PhoneNumberConfirmed" NUMBER(1,0), 
	"TwoFactorEnabled" NUMBER(1,0), 
	"LockoutEndDateUtc" TIMESTAMP (7), 
	"LockoutEnabled" NUMBER(1,0), 
	"AccessFailedCount" NUMBER(10,0), 
	"UserName" NVARCHAR2(256)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index SYS_C007529
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYSTEM"."SYS_C007529" ON "SYSTEM"."AspNetUsers" ("Id") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  Constraints for Table AspNetUsers
--------------------------------------------------------

  ALTER TABLE "SYSTEM"."AspNetUsers" MODIFY ("Id" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUsers" MODIFY ("EmailConfirmed" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUsers" MODIFY ("PhoneNumberConfirmed" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUsers" MODIFY ("TwoFactorEnabled" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUsers" MODIFY ("LockoutEnabled" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUsers" MODIFY ("AccessFailedCount" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUsers" MODIFY ("UserName" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUsers" ADD PRIMARY KEY ("Id")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
