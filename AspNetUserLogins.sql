--------------------------------------------------------
--  File created - Thursday-December-07-2017   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table AspNetUserLogins
--------------------------------------------------------

  CREATE TABLE "SYSTEM"."AspNetUserLogins" 
   (	"LoginProvider" NVARCHAR2(128), 
	"ProviderKey" NVARCHAR2(128), 
	"UserId" NVARCHAR2(128)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index SYS_C007536
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYSTEM"."SYS_C007536" ON "SYSTEM"."AspNetUserLogins" ("LoginProvider", "ProviderKey", "UserId") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index IX_AspNetUserLogins_UserId
--------------------------------------------------------

  CREATE INDEX "SYSTEM"."IX_AspNetUserLogins_UserId" ON "SYSTEM"."AspNetUserLogins" ("UserId") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  Constraints for Table AspNetUserLogins
--------------------------------------------------------

  ALTER TABLE "SYSTEM"."AspNetUserLogins" MODIFY ("LoginProvider" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUserLogins" MODIFY ("ProviderKey" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUserLogins" MODIFY ("UserId" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUserLogins" ADD PRIMARY KEY ("LoginProvider", "ProviderKey", "UserId")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
