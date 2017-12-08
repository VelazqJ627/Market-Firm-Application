--------------------------------------------------------
--  File created - Thursday-December-07-2017   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table AspNetUserRoles
--------------------------------------------------------

  CREATE TABLE "SYSTEM"."AspNetUserRoles" 
   (	"UserId" NVARCHAR2(128), 
	"RoleId" NVARCHAR2(128)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Index SYS_C007521
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYSTEM"."SYS_C007521" ON "SYSTEM"."AspNetUserRoles" ("UserId", "RoleId") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  Constraints for Table AspNetUserRoles
--------------------------------------------------------

  ALTER TABLE "SYSTEM"."AspNetUserRoles" MODIFY ("UserId" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUserRoles" MODIFY ("RoleId" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."AspNetUserRoles" ADD PRIMARY KEY ("UserId", "RoleId")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
