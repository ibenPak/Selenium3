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
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleWindow.ConsoleAttributes();
            Global.ReadySetGo(NumBrowsers.One);

            //////////////////////////////////////////////////////////////////////////
            //                                                                      //
            //                           Code Below Here                            //
            //                                                                      //
            //////////////////////////////////////////////////////////////////////////

            Runner_QA.REOFlowOrg2(Driver.driver1);

         



            Global.ApplicationPause("Wait here");

            Login.ValPortal(Driver.driver1, ENV.QA, "test3", "P@ssw0rd1");
            SeleniumSetMethods.Wait(Driver.driver1, ElementType.Id, "searchBar");
            SeleniumGetMethods.IsPresent(Driver.driver1, ElementType.Id, "searchBar");
            if (Global.IsPresent == true)
            {
                Global.ConsoleOutTab("I'm here");

            }

            // Cool Down
            Global.Cooldown();

            // Test was executed successfully 
            Global.Done();

        }

    }

}

