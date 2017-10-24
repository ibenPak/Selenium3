﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Selenium3
{
    class Logout
    {
        
        public static void Portal(Driver driver, Portals portals)
        {
            int tries = 0;
            bool IsElementPresent = false;
            while (IsElementPresent == false)
            {
                try
                {
                    tries = tries + 1;
                    // Check to see if Logout WebElement is Present
                 
                    if (portals == Portals.ValPortal)
                    {
                        SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "#Header > header > div.right > nav > div:nth-child(7) > a");
                        SeleniumWindowMethods.Sleep(1);
                        SeleniumSetMethods.Click(driver, ElementType.CssSelector, "#Header > header > div.right > nav > div:nth-child(7) > a");
                       
                    }
                    else if (portals == Portals.Agent)
                    {
                        SeleniumSetMethods.Wait(driver, ElementType.Id, "ctl00_ctl00_ctrHeader_LoginState1_hlLogout");
                        SeleniumWindowMethods.Sleep(1);
                        SeleniumSetMethods.Click(driver, ElementType.Id, "ctl00_ctl00_ctrHeader_LoginState1_hlLogout");
                    }
                    else if (portals == Portals.Vendor)
                    {
                        SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= '/Authentication/Logout']");
                        SeleniumWindowMethods.Sleep(1);
                        SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= '/Authentication/Logout']");
                    }
                    else if (portals == Portals.REO)
                    {
                        SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "a[href *= 'AM_LOGOUT']");
                        SeleniumWindowMethods.Sleep(1);
                        SeleniumSetMethods.Click(driver, ElementType.CssSelector, "a[href *= 'AM_LOGOUT']");
                    }
                    else if (portals == Portals.PropertyCure)
                    {
                        SeleniumSetMethods.Wait(driver, ElementType.CssSelector, "i.fa.fa-caret-down");
                        SeleniumWindowMethods.Sleep(1);
                        SeleniumSetMethods.Click(driver, ElementType.CssSelector, "i.fa.fa-caret-down");
                        SeleniumSetMethods.Click(driver, ElementType.Id, "btnLogout");
                    }
                    
                    IsElementPresent = true;
                    Global.ConsoleOut("Logout WebElement " + portals + " found");
                    break;

                }
                catch
                {
                    Global.ConsoleOut("Logout WebElement " + portals + " not found, " + tries + " attempted");
                    SeleniumWindowMethods.Sleep(3);
                }
                if (tries == 15)
                {
                    Global.ConsoleOut("Logout WebElement " + portals + " not found, and " + tries + " maxium tries has been reached");

                    break; // handle error and break/return
                }

            }

        }

    }

}
