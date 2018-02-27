﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;

namespace Selenium3
{
    class Form_REOTasks
    {
        public static void Winterization(Driver driver, string AgentName)
        {
            SeleniumSetMethods.Wait(driver, ElementType.Name, "wsrWinterize");
            SeleniumSetMethods.Click(driver, ElementType.Name, "wsrWinterize");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "wsrSigned", AgentName);
            SeleniumSetMethods.Click(driver, ElementType.Name, "wsrWinterize");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnSaveSubmit");

        }

        public static void OccupancyStatusTask(Driver driver)
        {
            SeleniumSetMethods.Wait(driver, ElementType.Name, "osCurChkDt");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "osCurChkDt", "03/02/17");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "osVacant", "Yes");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "osPropType", "SFR");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "osList", "Yes");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "osUnCoop", "No");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "osBox", "1234");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "osLegal", "1");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "osLegal1", "Vacant Secure");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "txtosAgentNote", "It's good to go");
            SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "#tabStandards > tbody:nth-child(1) > tr:nth-child(6) > td:nth-child(1) > table:nth-child(2) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(2) > input:nth-child(3)", "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\AUpload.pdf");
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnSaveSubmit");

        }

        public static void TaxResearchTask(Driver driver)
        {
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "taxCounty", "Orange");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "taxParcel", "1234567");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "taxTaxContact", "995422");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "taxTaxContactPh", "9493331234");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "tax1Yr", "2017");
            SeleniumSetMethods.Clear(driver, ElementType.Name, "tax1AmtDue");
            SeleniumSetMethods.Clear(driver, ElementType.Name, "tax1Penalties");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "tax1AmtDue", "500.00");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "tax1Penalties", "7.00");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "taxTaxExpDt", "01/02/18");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@name='taxLiens'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@name='taxTaxSale'])[2]");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "txtTaxCheck", "USRES");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnSaveSubmit");

        }

        public static void ReferralFeeAgreement(Driver driver, string AgentName)
        {
            SeleniumSetMethods.Wait(driver, ElementType.Name, "raSigned");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "raSigned", AgentName);
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnSaveSubmit");

        }

        public static void ListingAddendum(Driver driver, string AgentName)
        {
            SeleniumSetMethods.Wait(driver, ElementType.Name, "laSigned");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "laSigned", AgentName);
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnSaveSubmit");

        }

        public static void HOAInformation(Driver driver)
        {
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "hoaReq", "Yes");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "hoaName", "Irvine Company");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "hoaContact", "Big Bird");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "hoaPhone", "949-333-5432");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "hoaPayment", "350");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "hoaPaymentDt", "01/01/17");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "hoaPastDue", "0");
            SeleniumSetMethods.SelectDropDown(driver, ElementType.Name, "hoaFreq", "Monthly");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "hoaHoaAddr", "20 Pacifica");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "hoaHoaCity", "Irvine");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "hoaHoaState", "CA");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "hoaHoaZip", "92618");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnSaveSubmit");

        }

        public static void AssetMGRTasks(Driver driver)
        {
            SeleniumSetMethods.Wait(driver, ElementType.Id, "globalPropertySearch");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "globalPropertySearch", Global.OrderID);
            SeleniumWindowMethods.Sleep(1);
            SeleniumSetMethods.Wait(driver, ElementType.Id, "qsAddress");
            SeleniumSetMethods.Click(driver, ElementType.Id, "qsAddress");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back(driver, "SCRA Referral (Custom)", "Custom Task");
            IfExists.Id_Refresh(driver, "globalPropertySearch", "Page Load");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[3]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[3]");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back(driver, "Sivad Custom task (Custom)", "Custom Task");
            IfExists.Id_Refresh(driver, "globalPropertySearch", "Page Load");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "Test1");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Test1", "yellow");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnUpdate");
            SeleniumSetMethods.Wait(driver, ElementType.LinkText, "Agent Listing Contract");
            SeleniumSetMethods.Click(driver, ElementType.LinkText, "Agent Listing Contract");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back(driver, "122314 Custom Task (Custom)", "Custom Task");
            IfExists.Id_Refresh(driver, "globalPropertySearch", "Custom Task");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "073113ListingCheckboxListCustom_test");
            SeleniumSetMethods.Click(driver, ElementType.Id, "073113ListingCheckboxListCustom_test");
            SeleniumSetMethods.Wait(driver, ElementType.Id, "btnUpdateAsDone");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdateAsDone");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back(driver, "Sivad Custom task (Custom)", "Custom Task");
            IfExists.Id_Refresh(driver, "globalPropertySearch", "Custom Task");
            SeleniumSetMethods.EnterText(driver, ElementType.Id, "Test1", "Enter Comment");
            SeleniumSetMethods.Click(driver, ElementType.Id, "btnUpdateAsDone");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back(driver, "Home Owners Assoc Information Request", "Custom Task");
            IfExists.Id_Refresh(driver, "globalPropertySearch", "Custom Task");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back(driver, "Tax Research Request", "Custom Task");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back(driver, "Listing Acknowledgement", "Custom Task");
            IfExists.Id_Refresh(driver, "globalPropertySearch", "Custom Task");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back(driver, "Referral Agreement", "Custom Task");
            IfExists.Id_Refresh(driver, "globalPropertySearch", "Custom Task");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back(driver, "Winterization Requirements Request", "Custom Task");
            IfExists.Id_Refresh(driver, "globalPropertySearch", "Custom Task");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_PROPTASKS']");
            IfExists.Link_Back(driver, "Occupancy Status Request", "Custom Task");
            IfExists.Id_Refresh(driver, "globalPropertySearch", "Custom Task");
            SeleniumSetMethods.Wait(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "(//input[@name='btnUpdate'])[2]");

        }

        public static void PropertyInspection(Driver driver)
        {
            SeleniumSetMethods.Wait(driver, ElementType.Name, "inspDate_visit");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "inspDate_visit", Global.LastMonth);
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspStatus_vacant");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspStatus_Personal_No");
            SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "#form-questions > table > tbody > tr > td:nth-child(1) > ul > li:nth-child(1) > div > ul > li:nth-child(1) > input[type=\"file\"]"
                , "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\B1.jpg");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspRe_keyed_No");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspLockBox_Yes");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "inspLockBox_Code", "12345");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspEvid_MOLD_No");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspSmoke_Yes");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "inspSmoke_How_many", "6");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspAir_cond_Yes");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspAir_cond_Opt_Yes");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspEvid_Hazardous_No");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspPool_No");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspCarpet_Yes");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "inspCarpet_Location", "Everywhere I look");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspCarpet_Recom_Clean_Yes");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "inspCarpet_Why", "Yes it's pretty dirty");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspSprinkler_Yes");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspSprinkler_Time_Pres_Yes");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspSprinkler_Oper_Yes");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspWater_Heater_Yes");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspWater_Heater_CA_Yes");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspRegulations_No");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspSafety_Hazards_No");
            SeleniumSetMethods.Click(driver, ElementType.Name, "inspEvid_Damage_No");
            SeleniumSetMethods.EnterText(driver, ElementType.CssSelector, "#form-questions > table > tbody > tr > td:nth-child(2) > ul > li:nth-child(7) > div > ul > li:nth-child(1) > input[type=\"file\"]"
                , "\\\\hqfs1\\Public\\IT\\QA\\Pictures\\B2.jpg");
            SeleniumSetMethods.EnterText(driver, ElementType.Name, "inspsignature_name", "iben");
            SeleniumSetMethods.Click(driver, ElementType.Name, "btnSaveSubmit");
            SeleniumSetMethods.Click(driver, ElementType.XPath, "xpath=(//input[@name='btnUpdate'])[2]");

        }

    }

}
