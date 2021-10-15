using Newtonsoft.Json;
using NLog;
using NTST.ScriptLinkService.Objects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Services;


namespace ScriptLinkStub
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OutPatientProgressNoteService : System.Web.Services.WebService
    {

        private static Logger log = LogManager.GetCurrentClassLogger();

        class OutPatientProgressNoteConfig
        {
            private static OutPatientProgressNoteConfig instance = null;
            private static Logger log = LogManager.GetCurrentClassLogger();


            public HashSet<string> Duration16To37 = new HashSet<string>();
            public HashSet<string> Duration38To52 = new HashSet<string>();
            public HashSet<string> Duration53Plus = new HashSet<string>();

            // Expanded Duration Checks - 09/08/2021
            public HashSet<string> Duration30To74 = new HashSet<string>();
            public HashSet<string> Duration8To247 = new HashSet<string>();
            public HashSet<string> Duration8To480 = new HashSet<string>();
            public HashSet<string> Duration248To480 = new HashSet<string>();
            public HashSet<string> Duration8To248 = new HashSet<string>();
            public HashSet<string> Duration0To248 = new HashSet<string>();
            public HashSet<string> Duration0To53 = new HashSet<string>();
            public HashSet<string> Duration0To26 = new HashSet<string>();
            public HashSet<string> Duration0To30 = new HashSet<string>();            
            public HashSet<string> Duration0To45 = new HashSet<string>();
            public HashSet<string> Duration0To8 = new HashSet<string>();
            public HashSet<string> Duration0To31 = new HashSet<string>();

            private static void init()
            {
                // NOTE - DATA DRIVE THIS - PUT INTO A TABLE AND USE A SELECT TO
                //        RETRIEVE THESE VALUES
                // Read Configuration
                using (FileStream fs = File.OpenRead("C:\\inetpub\\wwwroot\\OutPatientProgressNote\\OutPatientProgressNote.json"))
                {
                    using (StreamReader configStreamReader = new StreamReader(fs))
                    {
                        string configStr = configStreamReader.ReadToEnd();
                        log.Debug("SDJL: configStr = '" + configStr + "'");
                        instance = JsonConvert.DeserializeObject<OutPatientProgressNoteConfig>(configStr);                        
                        log.Debug("Config = Duration16To37 " + OutPatientProgressNoteConfig.getInstance().GetDuration16To37().ToString());
                        log.Debug("Config = Duration16To37 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration16To37().Count());
                        log.Debug("Config = Duration38To52 " + OutPatientProgressNoteConfig.getInstance().GetDuration38To52().ToString());
                        log.Debug("Config = Duration38To52 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration38To52().Count());
                        log.Debug("Config = Duration53Plus " + OutPatientProgressNoteConfig.getInstance().GetDuration53Plus().ToString());
                        log.Debug("Config = Duration53Plus Count" + OutPatientProgressNoteConfig.getInstance().GetDuration53Plus().Count());
                        log.Debug("Config = Duration30To74 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration30To74().Count());
                        log.Debug("Config = Duration8To247 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration8To247().Count());
                        log.Debug("Config = Duration248To480 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration248To480().Count());
                        log.Debug("Config = Duration8To248 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration8To248().Count());
                        log.Debug("Config = Duration0To248 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration0To248().Count());
                        log.Debug("Config = Duration0To53 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration0To53().Count());
                        log.Debug("Config = Duration0To26 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration0To26().Count());
                        log.Debug("Config = Duration0To30 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration0To30().Count());
                        log.Debug("Config = Duration0To30 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration0To30().Count());
                        log.Debug("Config = Duration0To45 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration0To45().Count());
                        log.Debug("Config = Duration0To8 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration0To8().Count());
                        log.Debug("Config = Duration0To31 Count" + OutPatientProgressNoteConfig.getInstance().GetDuration0To31().Count());

                    }
                }

            }

            public static OutPatientProgressNoteConfig getInstance()
            {
                if (instance == null)
                {
                    init();
                }
                return instance;
            }

            public static OutPatientProgressNoteConfig GetOutPatientProgressNoteConfig()
            {
                if (instance == null)
                {
                    init();
                }
                return instance;
            }

            public static void SetOutPatientProgressNoteConfig(OutPatientProgressNoteConfig config)
            {
                instance = config;
            }

            public HashSet<string> GetDuration0To31()
            {
                return Duration0To31;
            }

            public void SetDuration0To31(HashSet<string> set)
            {
                Duration0To31 = set;
            }


            public HashSet<string> GetDuration0To8()
            {
                return Duration0To8;
            }

            public void SetDuration0To8(HashSet<string> set)
            {
                Duration0To8 = set;
            }


            public HashSet<string> GetDuration0To45()
            {
                return Duration0To45;
            }

            public void SetDuration0To45(HashSet<string> set)
            {
                Duration0To45 = set;
            }




            public HashSet<string> GetDuration0To30()
            {
                return Duration0To30;
            }

            public void SetDuration0To30(HashSet<string> set)
            {
                Duration0To30 = set;
            }


            public HashSet<string> GetDuration0To26()
            {
                return Duration0To26;
            }

            public void SetDuration0To26(HashSet<string> set)
            {
                Duration0To26 = set;
            }

            public HashSet<string> GetDuration0To53()
            {
                return Duration0To53;
            }

            public void SetDuration0To53(HashSet<string> set)
            {
                Duration0To53 = set;
            }


            public HashSet<string> GetDuration0To248()
            {
                return Duration0To248;
            }

            public void SetDuration0To248(HashSet<string> set)
            {
                Duration0To248 = set;
            }

            public HashSet<string> GetDuration8To248()
            {
                return Duration8To248;
            }

            public void SetDuration8To248(HashSet<string> set)
            {
                Duration8To248 = set;
            }

            public HashSet<string> GetDuration8To480()
            {
                return Duration8To480;
            }

            public void SetDuration8To480(HashSet<string> set)
            {
                Duration8To480 = set;
            }


            public HashSet<string> GetDuration248To480()
            {
                return Duration248To480;
            }

            public void SetDuration248To480(HashSet<string> set)
            {
                Duration248To480 = set;
            }

            public HashSet<string> GetDuration8To247()
            {
                return Duration8To247;
            }

            public void SetDuration8To247(HashSet<string> set)
            {
                Duration8To247 = set;
            }

            public HashSet<string> GetDuration30To74()
            {
                return Duration30To74;
            }

            public void SetDuration30To74(HashSet<string> set)
            {
                Duration30To74 = set;
            }

            public HashSet<string> GetDuration16To37()
            {
                return Duration16To37;
            }

            public void SetDuration16To37(HashSet<string> set)
            {
                Duration16To37 = set;
            }

            public HashSet<string> GetDuration38To52()
            {
                return Duration38To52;
            }

            public void SetDuration38To52(HashSet<string> set)
            {
                Duration38To52 = set;
            }


            public HashSet<string> GetDuration53Plus()
            {
                return Duration53Plus;
            }

            public void SetDuration53Plus(HashSet<string> set)
            {
                Duration53Plus = set;
            }

        }

        [WebMethod]
        public string GetVersion()
        {
            log.Debug("SDJL Expanded Duration Checks Version Check 1.1");
            return "1.1";
        }

        [WebMethod]
        public OptionObject2015 RunScript(OptionObject2015 inputObject, String scriptParameter)
        {
            OptionObject2015 returnObject = CopyObject(inputObject);
            int duration = 0;
            string typeOfService = "";

            try
            {
                log.Debug("-----------------------------------------");
                log.Debug("SDJL - BEGIN OutPatient ProgressNote RunScript '" + scriptParameter + "'");
                OutPatientProgressNoteConfig config = OutPatientProgressNoteConfig.getInstance();

                switch (scriptParameter)
                {
                    case "HS_OutpatientProgerssNote CheckDuration":
                        log.Debug("Check Progress Node Duration");
                        foreach (FormObject form in inputObject.Forms)
                        {
                            log.Debug("Form ID: " + form.FormId);
                            foreach (FieldObject field in form.CurrentRow.Fields)
                            {
                                //log.Debug("SDJL FieldNumber '" + field.FieldNumber + "'");
                                //log.Debug("SDJL FieldValue '" + field.FieldValue + "'");
                                switch (field.FieldNumber)
                                {
                                    case "51003":
                                        if (field.FieldValue.Length > 0)
                                        {
                                            duration = (int)Int64.Parse(field.FieldValue);
                                            log.Debug("Duration: " + duration);
                                        }
                                        else
                                        {
                                            log.Debug("Duration: Empty: Using Default: "+duration);
                                        }
                                        break;

                                    case "51001":
                                        typeOfService = field.FieldValue.Trim();
                                        log.Debug("Type of Service: '" + typeOfService + "'");
                                        break;
                                }
                            }
                        }
                        log.Debug("TypeOfService Check '" + typeOfService + "'");
                        log.Debug("Contains: config.GetDuration16To37().Contains(typeOfService)" + config.GetDuration16To37().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration16To37().Count() " + config.GetDuration16To37().Count());
                        log.Debug("Contains: config.GetDuration38To52().Contains(typeOfService)" + config.GetDuration38To52().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration38To52().Count() " + config.GetDuration38To52().Count());
                        log.Debug("Contains: config.GetDuration53Plus().Contains(typeOfService)" + config.GetDuration53Plus().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration53Plus().Count() " + config.GetDuration53Plus().Count());

                        // Expanded duration checks
                        log.Debug("Contains: config.GetDuration30To74().Contains(typeOfService)" + config.GetDuration30To74().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration30To74().Count() " + config.GetDuration30To74().Count());
                        log.Debug("Contains: config.GetDuration8To247().Contains(typeOfService)" + config.GetDuration8To247().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration8To247().Count() " + config.GetDuration8To247().Count());
                        log.Debug("Contains: config.GetDuration248To480().Contains(typeOfService)" + config.GetDuration248To480().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration248To480().Count() " + config.GetDuration248To480().Count());
                        log.Debug("Contains: config.GetDuration8To248().Contains(typeOfService)" + config.GetDuration8To248().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration8To248().Count() " + config.GetDuration8To248().Count());
                        log.Debug("Contains: config.GetDuration0To248().Contains(typeOfService)" + config.GetDuration0To248().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration0To248().Count() " + config.GetDuration0To248().Count());
                        log.Debug("Contains: config.GetDuration0To53().Contains(typeOfService)" + config.GetDuration0To53().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration0To53().Count() " + config.GetDuration0To53().Count());
                        log.Debug("Contains: config.GetDuration0To26().Contains(typeOfService)" + config.GetDuration0To26().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration0To26().Count() " + config.GetDuration0To26().Count());
                        log.Debug("Contains: config.GetDuration0To30().Contains(typeOfService)" + config.GetDuration0To30().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration0To30().Count() " + config.GetDuration0To30().Count());
                        log.Debug("Contains: config.GetDuration0To45().Contains(typeOfService)" + config.GetDuration0To45().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration0To45().Count() " + config.GetDuration0To45().Count());
                        log.Debug("Contains: config.GetDuration0To8().Contains(typeOfService)" + config.GetDuration0To8().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration0To8().Count() " + config.GetDuration0To8().Count());
                        log.Debug("Contains: config.GetDuration0To31().Contains(typeOfService)" + config.GetDuration0To31().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration0To31().Count() " + config.GetDuration0To31().Count());


                        if (config.GetDuration16To37().Contains(typeOfService))
                        {
                            log.Debug("SDJL 90832 - 16<=Duration<=37 Check");
                            if ((duration < 16) || (duration > 37))
                            {
                                log.Debug("SDJL 90832 - FAILED 16<=Duration<=37 Check");
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 16-37 minutes";
                            }
                        }
                        else if (config.GetDuration38To52().Contains(typeOfService))
                        {
                            log.Debug("SDJL 90834 - 38<=Duration<=52 Check");
                            if ((duration < 38) || (duration > 52))
                            {
                                log.Debug("SDJL 90834 - FAILED 38<=Duration<=52 Check");
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 38-52 minutes";
                            }
                        }
                        else if (config.GetDuration53Plus().Contains(typeOfService))
                        {
                            log.Debug("SDJL 90837 - Duration < 53 Check");
                            if (duration < 53)
                            {
                                log.Debug("SDJL 90837 - FAILED Duration>=53 Check");
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 53+ minutes";
                            }
                        }

                        // Expanded Duration Checks
                        else if (config.GetDuration30To74().Contains(typeOfService))
                        {
                            log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 30<=Duration<=74 Check");
                            if ((duration < 30) || (duration > 74))
                            {
                                log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 30<=Duration<=74 Check");
                                log.Debug("For " + typeOfService + ", Duration must be 30 - 74 minutes");
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 30-74 minutes";
                            }
                            else
                            {
                                log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " - PASSED 30<=Duration<=74 Check");
                            }
                        }
                        else if (config.GetDuration8To247().Contains(typeOfService))
                        {
                            log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- 8<=Duration<=247 Check");
                            if ((duration < 8) || (duration > 247))
                            {
                                log.Debug("SDJL Expanded Duration Checks: "+typeOfService+" - FAILED 8<=Duration<=247 Check");                                
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 8-247 minutes";
                            }
                            else
                            {
                                log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " - PASSED 8<=Duration<=247 Check");
                            }

                        }
                        else if (config.GetDuration248To480().Contains(typeOfService))
                        {
                            log.Debug("SDJL Expanded Duration Checks " + typeOfService + " - FAILED 248<=Duration<=480 Check");
                            if ((duration < 248) || (duration > 480))
                            {
                                log.Debug("SDJL Expanded Duration Checks - FAILED 248<=Duration<=480 Check");
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 248-480 minutes";
                            }
                            else
                            {
                                log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " - PASSED 248<=Duration<=480 Check");
                            }
                        }
                        else if (config.GetDuration8To248().Contains(typeOfService))
                        {
                            log.Debug("SDJL Expanded Duration Checks - 8<=Duration<=248 Check");
                            if ((duration < 8) || (duration > 248))
                            {
                                log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 8<=Duration<=248 Check");
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 8-248 minutes";
                            }
                            else
                            {
                                log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " - PASSED 8<=Duration<=248 Check");
                            }
                        }
                        else if (config.GetDuration0To248().Contains(typeOfService))
                        {
                            log.Debug("SDJL Expanded Duration Checks - 0<=Duration<=248 Check");
                            if ((duration < 0) || (duration > 248))
                            {
                                log.Debug("SDJL Expanded Duration Checks - FAILED 0<=Duration<=248 Check");
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 0-248 minutes";
                            }
                            else
                            {
                                log.Debug("SDJL Expanded Duration Checks Service Code: "+ typeOfService + "- PASSED 0<=Duration<=248 Check");
                            }
                        }
                        else if (config.GetDuration0To53().Contains(typeOfService))
                        {
                            log.Debug("SDJL Expanded Duration Checks - 0<=Duration<=53 Check");
                            if ((duration < 0) || (duration > 53))
                            {
                                log.Debug("SDJL Expanded Duration Checks - FAILED 0<=Duration<=53 Check");
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 0-53 minutes";
                            }
                            else
                            {
                                log.Debug("SDJL Expanded Duration Checks Service Code: " + typeOfService + "- PASSED 0<=Duration<=53 Check");
                            }
                        }
                        else if (config.GetDuration0To26().Contains(typeOfService))
                        {
                            log.Debug("SDJL Expanded Duration Checks - 0<=Duration<=26 Check");
                            if ((duration < 0) || (duration > 26))
                            {
                                log.Debug("SDJL Expanded Duration Checks - FAILED 0<=Duration<=26 Check");
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 0-26 minutes";
                            }
                            else
                            {
                                log.Debug("SDJL Expanded Duration Checks Service Code: " + typeOfService + "- PASSED 0<=Duration<=26 Check");
                            }
                        }
                        else if (config.GetDuration0To30().Contains(typeOfService))
                        {
                            log.Debug("SDJL Expanded Duration Checks - 0<=Duration<=30 Check");
                            if ((duration < 0) || (duration > 30))
                            {
                                log.Debug("SDJL Expanded Duration Checks - FAILED 0<=Duration<=30 Check");
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 0-30 minutes";
                            }
                            else
                            {
                                log.Debug("SDJL Expanded Duration Checks Service Code: " + typeOfService + "- PASSED 0<=Duration<=30 Check");
                            }
                        }
                        else if (config.GetDuration0To45().Contains(typeOfService))
                        {
                            log.Debug("SDJL Expanded Duration Checks - 0<=Duration<=45 Check");
                            if ((duration < 0) || (duration > 45))
                            {
                                log.Debug("SDJL Expanded Duration Checks Service Code: "+typeOfService+" - FAILED 0<=Duration<=45 Check");
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 0-45 minutes";
                            }
                            else
                            {
                                log.Debug("SDJL Expanded Duration Checks Service Code: " + typeOfService + "- PASSED 0<=Duration<=45 Check");
                            }
                        }
                        else if (config.GetDuration0To8().Contains(typeOfService))
                        {
                            log.Debug("SDJL Expanded Duration Checks - 0<=Duration<=8 Check");
                            if ((duration < 0) || (duration > 8))
                            {
                                log.Debug("SDJL Expanded Duration Checks Service Code: "+typeOfService+" - FAILED 0<=Duration<=8 Check");
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 0-8 minutes";
                            }
                            else
                            {
                                log.Debug("SDJL Expanded Duration Checks Service Code: " + typeOfService + "- PASSED 0<=Duration<=8 Check");
                            }
                        }
                        else if (config.GetDuration0To31().Contains(typeOfService))
                        {
                            log.Debug("SDJL Expanded Duration Checks - 0<=Duration<=31 Check");
                            if ((duration < 0) || (duration > 31))
                            {
                                log.Debug("SDJL Expanded Duration Checks ServiceCode: "+typeOfService+" - FAILED 0<=Duration<=31 Check");
                                returnObject.ErrorCode = 1;
                                returnObject.ErrorMesg = "For " + typeOfService + ", Duration must be 0-31 minutes";
                            }
                            else
                            {
                                log.Debug("SDJL Expanded Duration Checks Service Code: " + typeOfService + "- PASSED 0<=Duration<=31 Check");
                            }
                        }

                        //  NO Duration checks required for this type of service
                        else
                        {
                            log.Debug("Service Code was not one of the codes requiring duration check");
                            returnObject.ErrorCode = 0;
                            returnObject.ErrorMesg = "";
                        }


                        break;

                }
                log.Debug("Test OutpatientProgressNote Debug");
                log.Debug("SDJL - END OutPatient ProgressNote RunScript '" + scriptParameter + "'");
                log.Debug("-----------------------------------------");
            }
            catch (Exception e)
            {
                log.Debug("Exception: e" + e.ToString());
            }

            return returnObject;
        }

        private static OptionObject2015 CopyObject(OptionObject2015 inputObject)
        {
            OptionObject2015 returnObject = new OptionObject2015();
            returnObject.OptionId = inputObject.OptionId;
            returnObject.Facility = inputObject.Facility;
            returnObject.SystemCode = inputObject.SystemCode;
            returnObject.NamespaceName = inputObject.NamespaceName;
            returnObject.ParentNamespace = inputObject.ParentNamespace;
            returnObject.ServerName = inputObject.ServerName;
            return returnObject;
        }
    }
}
