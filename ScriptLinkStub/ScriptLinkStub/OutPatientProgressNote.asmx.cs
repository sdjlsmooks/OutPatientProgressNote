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
            return "1.0";
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
