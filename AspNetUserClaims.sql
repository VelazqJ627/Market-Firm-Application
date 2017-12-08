--------------------------------------------------------
--  File created - Thursday-December-07-2017   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table AspNetUserClaims
--------------------------------------------------------

  CREATE TABLE "SYSTEM"."AspNetUserClaims" 
   (	"Id" NUMBER(10,0), 
	"UserId" NVARCHAR2(128), 
	"ClaimType" NVARCHAR2(256), 
	"ClaimValue" NVARCHAR2(256)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index SYS_C007532
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYSTEM"."SYS_C007532" ON "SYSTEM"."AspNetUserClaims" ("Id") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Trigger AspNetUserClaims_INS_TRG
--------------------------------------------------------

  CREATE OR REPLACE NONEDITIONABLE TRIGGER "SYSTEM"."AspNetUserClaims_INS_TRG" 
  BEFORE INSERT ON "AspNetUserClaims"
  FOR EACH ROW
BEGIN
  SELECT "AspNetUserClaims_SEQ".NEXTVAL INTO :NEW."Id" FROM DUAL;
END;
/
ALTER TRIGGER "SYSTEM"."AspNetUserClaims_INS_TRG" ENABLE;
--------------------------------------------------------
--  Constraints for Table AspNetUserClaims
--------------------------------------------------------

  ALTER TABLE "SYSTEM"."AspNetUserClaims" MODIFY ("Id" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUserClaims" MODIFY ("UserId" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUserClaims" ADD PRIMARY KEY ("Id")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
