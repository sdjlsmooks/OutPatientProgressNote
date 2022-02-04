using Newtonsoft.Json;
using NLog;
using NTST.ScriptLinkService.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            // Expanded Duration Checks - New from "Uniform Service Coding Standards Manual"
            // For October 2021
            //
            // NOTE - Per Scott Jones NoMax in the USCSM translates to 24Hrs per HS
            // business policies
            public HashSet<string> Duration241To24Hrs = new HashSet<string>();
            public HashSet<string> Duration248To480 = new HashSet<string>();
            public HashSet<string> Duration248To24Hrs = new HashSet<string>();
            public HashSet<string> Duration26To24Hrs = new HashSet<string>();
            public HashSet<string> Duration30To74 = new HashSet<string>();
            public HashSet<string> Duration30To24Hrs = new HashSet<string>();

            // Already defined in original set - use as placeholder to keep in sync with list
            //public HashSet<string> Duration38To52 = new HashSet<string>();

            public HashSet<string> Duration45To24Hrs = new HashSet<string>();
            public HashSet<string> Duration53To24Hrs = new HashSet<string>();
            public HashSet<string> Duration8To240 = new HashSet<string>();
            public HashSet<string> Duration8To247 = new HashSet<string>();
            public HashSet<string> Duration8To480 = new HashSet<string>();
            public HashSet<string> Duration8To24Hrs = new HashSet<string>();
            public HashSet<string> Duration0To24Hrs = new HashSet<string>();


            public HashSet<string> Duration60To24Hrs = new HashSet<string>();
            public HashSet<string> Duration8To90 = new HashSet<string>();
            public HashSet<string> Duration8To60 = new HashSet<string>();
            public HashSet<string> Duration1To247 = new HashSet<string>();
            public HashSet<string> Duration1To120 = new HashSet<string>();
            public HashSet<string> Duration15To24Hrs = new HashSet<string>();
            public HashSet<string> Duration16To24Hrs = new HashSet<string>();



            // Expanded Duration Checks - 09/08/2021
            //public HashSet<string> Duration30To74 = new HashSet<string>();
            //public HashSet<string> Duration8To247 = new HashSet<string>();
            //public HashSet<string> Duration8To480 = new HashSet<string>();
            //public HashSet<string> Duration248To480 = new HashSet<string>();
            //public HashSet<string> Duration8To248 = new HashSet<string>();
            //public HashSet<string> Duration0To248 = new HashSet<string>();
            //public HashSet<string> Duration0To53 = new HashSet<string>();
            //public HashSet<string> Duration0To26 = new HashSet<string>();
            //public HashSet<string> Duration0To30 = new HashSet<string>();            
            //public HashSet<string> Duration0To45 = new HashSet<string>();
            //public HashSet<string> Duration0To8 = new HashSet<string>();
            //public HashSet<string> Duration0To31 = new HashSet<string>();


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


            public HashSet<string> GetDuration241To24Hrs()
            {
                return Duration241To24Hrs;
            }

            public void SetDuration241To24Hrs(HashSet<string> set)
            {
                Duration241To24Hrs = set;
            }


            public HashSet<String> GetDuration248To480()
            {
                return Duration248To480;
            }

            public void SetDuration248To480(HashSet<string> set)
            {
                Duration248To480 = set;
            }


            public HashSet<string> GetDuration248To24Hrs()
            {
                return Duration248To24Hrs;
            }

            public void SetDuration248To24Hrs(HashSet<string> set)
            {
                Duration248To24Hrs = set;
            }

            public HashSet<string> GetDuration26To24Hrs()
            {
                return Duration26To24Hrs;
            }

            public void GetDuration26To24Hrs(HashSet<string> set)
            {
                Duration26To24Hrs = set;
            }

            public HashSet<string> GetDuration30To74()
            {
                return Duration30To74;
            }

            public void SetDuration30To74(HashSet<string> set)
            {
                Duration30To74 = set;
            }


            public HashSet<string> GetDuration30To24Hrs()
            {
                return Duration30To24Hrs;
            }

            public void SetDuration30To24Hrs(HashSet<string> set)
            {
                Duration30To24Hrs = set;
            }


            public HashSet<string> GetDuration45To24Hrs()
            {
                return Duration45To24Hrs;
            }

            public void SetDuration45To24Hrs(HashSet<string> set)
            {
                Duration45To24Hrs = set;
            }

            public HashSet<string> GetDuration53To24Hrs()
            {
                return Duration53To24Hrs;
            }

            public void SetDuration53To24Hrs(HashSet<string> set)
            {
                Duration53To24Hrs = set;
            }

            public HashSet<string> GetDuration8To240()
            {
                return Duration8To240;
            }

            public void SetDuration8To240(HashSet<string> set)
            {
                Duration8To240 = set;
            }

            public HashSet<string> GetDuration8To247()
            {
                return Duration8To247;
            }

            public void SetDuration8To247(HashSet<string> set)
            {
                Duration8To247 = set;
            }

            public HashSet<string> GetDuration8To480()
            {
                return Duration8To480;
            }

            public void SetDuration8To480(HashSet<string> set)
            {
                Duration8To480 = set;
            }

            public HashSet<string> GetDuration8To24Hrs()
            {
                return Duration8To24Hrs;
            }

            public void SetDuration8To24Hrs(HashSet<string> set)
            {
                Duration8To24Hrs = set;
            }

            public HashSet<string> GetDuration0To24Hrs()
            {
                return Duration0To24Hrs;
            }

            public void SetDuration0To24Hrs(HashSet<string> set)
            {
                Duration0To24Hrs = set;
            }

            public HashSet<string> getDuration45To24Hrs()
            {
                return Duration45To24Hrs;

            }

            public void setDuration45To24Hrs(HashSet<string> set)
            {
                Duration45To24Hrs = set;
            }


            public HashSet<string> GetDuration60To24Hrs()
            {
                return Duration60To24Hrs;
            }

            public void setDuration60To24Hrs(HashSet<string> set)
            {
                Duration60To24Hrs = set;
            }


            public HashSet<string> GetDuration8To90()
            {
                return Duration8To90;
            }

            public void SetDuration8To90(HashSet<string> set) 
            { 
                Duration8To90 = set;
            }


            public HashSet<string> GetDuration8To60()
            {
                return Duration8To60;
            }

            public void SetDuration8To60(HashSet<string> set)
            {
                Duration8To60 = set;
            }

            public HashSet<string> GetDuration1To247()
            {
                return Duration1To247;
            }

            
            public void SetDuration1To247(HashSet<string> set)
            {
                Duration1To247 = set;
            }

            public HashSet<string> GetDuration1To120()
            {
                return Duration1To120;
            }

            public void SetDuration1To120(HashSet<string> set)
            {
                Duration1To120 = set;
            }

            public HashSet<string> GetDuration15To24Hrs()
            {
                return Duration15To24Hrs;
            }

            public void SetDuration15To24Hrs(HashSet<string> set)
            {
                Duration15To24Hrs = set;

            }


            public HashSet<string> GetDuration16To24Hrs()
            {
                return Duration16To24Hrs;
            }

            public void SetDuration16To24Hrs(HashSet<string> set)
            {
                Duration16To24Hrs = set;
            }

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
                        log.Debug("Config = Duration38To52 " + OutPatientProgressNoteConfig.getInstance().GetDuration38To52().ToString());
                        log.Debug("Config = Duration53Plug " + OutPatientProgressNoteConfig.getInstance().GetDuration53Plus().ToString());
                        log.Debug("Config = Duration241To24Hrs " + OutPatientProgressNoteConfig.getInstance().GetDuration241To24Hrs().ToString());
                        log.Debug("Config = Duration248To480 " + OutPatientProgressNoteConfig.getInstance().GetDuration248To480().ToString());
                        log.Debug("Config = Duration248To24Hrs " + OutPatientProgressNoteConfig.getInstance().GetDuration248To24Hrs().ToString());
                        log.Debug("Config = Duration26To24Hrs " + OutPatientProgressNoteConfig.getInstance().GetDuration26To24Hrs().ToString());
                        log.Debug("Config = Duration30To37 " + OutPatientProgressNoteConfig.getInstance().GetDuration30To74().ToString());
                        log.Debug("Config = Duration30To24Hrs " + OutPatientProgressNoteConfig.getInstance().GetDuration30To24Hrs().ToString());
                        log.Debug("Config = Duration45To24Hrs " + OutPatientProgressNoteConfig.getInstance().GetDuration45To24Hrs().ToString());
                        log.Debug("Config = Duration53To24Hrs " + OutPatientProgressNoteConfig.getInstance().GetDuration53To24Hrs().ToString());
                        log.Debug("Config = Duration8To240 " + OutPatientProgressNoteConfig.getInstance().GetDuration8To240().ToString());
                        log.Debug("Config = Duration8To247 " + OutPatientProgressNoteConfig.getInstance().GetDuration8To247().ToString());
                        log.Debug("Config = Duration8To480 " + OutPatientProgressNoteConfig.getInstance().GetDuration8To480().ToString());
                        log.Debug("Config = Duration8To24Hrs " + OutPatientProgressNoteConfig.getInstance().GetDuration8To24Hrs().ToString());
                        log.Debug("Config = Duration0To24Hrs " + OutPatientProgressNoteConfig.getInstance().GetDuration0To24Hrs().ToString());
                        log.Debug("Config = Duration60To24Hrs " + OutPatientProgressNoteConfig.getInstance().GetDuration60To24Hrs().ToString());
                        log.Debug("Config = Duration8To90 " + OutPatientProgressNoteConfig.getInstance().GetDuration8To90().ToString());
                        log.Debug("Config = Duration8To60 " + OutPatientProgressNoteConfig.getInstance().GetDuration8To60().ToString());
                        log.Debug("Config = Duration1To247 " + OutPatientProgressNoteConfig.getInstance().GetDuration1To247().ToString());
                        log.Debug("Config = Duration1To120 " + OutPatientProgressNoteConfig.getInstance().GetDuration1To120().ToString());
                        log.Debug("Config = Duration15To24Hrs " + OutPatientProgressNoteConfig.getInstance().GetDuration15To24Hrs().ToString());
                        log.Debug("Config = Duration16To24Hrs " + OutPatientProgressNoteConfig.getInstance().GetDuration16To24Hrs().ToString());
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
            int durationFieldValue = 0;
            DateTime? serviceStartTime = null;
            DateTime? serviceEndTime = null;
            string typeOfService = "";

            try
            {
                log.Debug("-----------------------------------------");
                log.Debug("SDJL - BEGIN OutPatient ProgressNote RunScript '" + scriptParameter + "'");
                OutPatientProgressNoteConfig config = OutPatientProgressNoteConfig.getInstance();

                log.Debug("SDJL OutpatientProgressNote scriptParameter: '" + scriptParameter + "' - 2 SDJL");
                log.Debug("SDJL: Originating IP: " + HttpContext.Current.Request.UserHostAddress);
                switch (scriptParameter)
                {
                    case "HS_OutpatientProgerssnote CheckDuration":
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

                                    // Service Start Time
                                    case "3003":
                                        log.Debug("Service Start Time Field Value: '" + field.FieldValue + "'");
                                        if (field.FieldValue.Trim().Length > 0)
                                        {
                                            // See if the user entered in something like Start=1100 End=1500 (2 Hr service)
                                            if (field.FieldValue.Length == 4)
                                            {
                                                try
                                                {
                                                    // Assume HHMM DateTime Format.
                                                    string str = "1300";
                                                    string format = "HHmm";
                                                    DateTime date;



                                                    DateTime.TryParseExact(str,
                                                                          format,
                                                                          System.Globalization.CultureInfo.InvariantCulture,
                                                                          System.Globalization.DateTimeStyles.None,
                                                                          out date);

                                                    // If the parse fails, the exception will be thrown and this
                                                    // line will never be reached.
                                                    serviceStartTime = date;
                                                }
                                                catch (FormatException e)
                                                {
                                                    log.Debug("SDJL - Parse Start Time '" + field.FieldValue + "' Format Exception: " + e.Message);
                                                }

                                            }
                                            if (serviceStartTime == null)
                                            {
                                                try
                                                {
                                                    serviceStartTime = DateTime.Parse(field.FieldValue);
                                                }
                                                catch (FormatException e)
                                                {
                                                    log.Debug("SDJL - Parse Start Time '" + field.FieldValue + "' Format Exception: " + e.Message);

                                                }
                                            }
                                        }
                                        else
                                        {
                                            // If nothing is in start time, abort the check, nothing to do.
                                            log.Debug("SDJL - Nothing in Start Time - ABORT CHECK");
                                            return returnObject;
                                        }
                                        break;

                                    // Service End Time End Time
                                    case "3004":
                                        log.Debug("Service End Time Field Value: '" + field.FieldValue + "'");
                                        if (field.FieldValue.Trim().Length > 0)
                                        {
                                            if (field.FieldValue.Length == 4)
                                            {
                                                try
                                                {
                                                    // Assume HHMM DateTime Format.
                                                    string str = "1300";
                                                    string format = "HHmm";
                                                    DateTime date;



                                                    DateTime.TryParseExact(str,
                                                                          format,
                                                                          System.Globalization.CultureInfo.InvariantCulture,
                                                                          System.Globalization.DateTimeStyles.None,
                                                                          out date);

                                                    // If the parse fails, the exception will be thrown and this
                                                    // line will never be reached.
                                                    serviceEndTime = date;
                                                }
                                                catch (FormatException e)
                                                {
                                                    log.Debug("SDJL - Parse End Time '" + field.FieldValue + "'" + "Format Exception: " + e.Message);
                                                }

                                            }
                                            if (serviceEndTime == null)
                                            {
                                                serviceEndTime = DateTime.Parse(field.FieldValue);
                                            }
                                        }
                                        break;

                                    // Duration Field
                                    case "51003":
                                        if (field.FieldValue.Length > 0)
                                        {
                                            durationFieldValue = (int)Int64.Parse(field.FieldValue);
                                            log.Debug("Duration Field Value: '" + durationFieldValue + "'");
                                        }
                                        else
                                        {
                                            log.Debug("Duration: Empty: Using Default: " + durationFieldValue);
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
                        log.Debug("Service Start Time = '" + serviceStartTime + "'");
                        log.Debug("Service End Time =- '" + serviceEndTime + "'");

                        int calculatedDurationMinutes = 0;

                        if ((serviceStartTime != null) && (serviceEndTime != null))
                        {
                            TimeSpan calculatedDuration = ((DateTime)serviceEndTime).Subtract((DateTime)serviceStartTime);
                            calculatedDurationMinutes = (int)calculatedDuration.TotalMinutes;
                        }
                        log.Debug("Calculated Duration Total Minutes = '" + calculatedDurationMinutes);


                        log.Debug("Contains: config.GetDuration16To37().Contains(typeOfService)" + config.GetDuration16To37().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration16To37().Count() " + config.GetDuration16To37().Count());
                        log.Debug("Contains: config.GetDuration38To52().Contains(typeOfService)" + config.GetDuration38To52().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration38To52().Count() " + config.GetDuration38To52().Count());
                        log.Debug("Contains: config.GetDuration53Plus().Contains(typeOfService)" + config.GetDuration53Plus().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration53Plus().Count() " + config.GetDuration53Plus().Count());

                        // Expanded duration checks
                        log.Debug("Contains: config.GetDuration16To37().Contains(typeOfService)" + config.GetDuration16To37().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration16To37().Count()" + config.GetDuration16To37().Count());
                        log.Debug("Contains: config.GetDuration38To52().Contains(typeOfService)" + config.GetDuration38To52().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration38To52().Count()" + config.GetDuration38To52().Count());
                        log.Debug("Contains: config.GetDuration53Plus().Contains(typeOfService)" + config.GetDuration53Plus().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration53Plus().Count()" + config.GetDuration53Plus().Count());
                        log.Debug("Contains: config.GetDuration241To24Hrs().Contains(typeOfService)" + config.GetDuration241To24Hrs().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration241To24Hrs().Count()" + config.GetDuration241To24Hrs().Count());
                        log.Debug("Contains: config.GetDuration248To480().Contains(typeOfService)" + config.GetDuration248To480().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration248To480().Count()" + config.GetDuration248To480().Count());
                        log.Debug("Contains: config.GetDuration248To24Hrs().Contains(typeOfService)" + config.GetDuration248To24Hrs().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration248To24Hrs().Count()" + config.GetDuration248To24Hrs().Count());
                        log.Debug("Contains: config.GetDuration26To24Hrs().Contains(typeOfService)" + config.GetDuration26To24Hrs().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration26To24Hrs().Count()" + config.GetDuration26To24Hrs().Count());
                        log.Debug("Contains: config.GetDuration30To74().Contains(typeOfService)" + config.GetDuration30To74().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration30To74().Count()" + config.GetDuration30To74().Count());
                        log.Debug("Contains: config.GetDuration30to24Hrs().Contains(typeOfService)" + config.GetDuration30To24Hrs().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration30to24Hrs().Count()" + config.GetDuration30To24Hrs().Count());
                        log.Debug("Contains: config.GetDuration45To24Hrs().Contains(typeOfService)" + config.GetDuration45To24Hrs().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration45To24Hrs().Count()" + config.GetDuration45To24Hrs().Count());
                        log.Debug("Contains: config.GetDuration53To24Hrs().Contains(typeOfService)" + config.GetDuration53To24Hrs().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration53To24Hrs().Count()" + config.GetDuration53To24Hrs().Count());
                        log.Debug("Contains: config.GetDuration8To240().Contains(typeOfService)" + config.GetDuration8To240().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration8To240().Count()" + config.GetDuration8To240().Count());
                        log.Debug("Contains: config.GetDuration8To247().Contains(typeOfService)" + config.GetDuration8To247().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration8To247().Count()" + config.GetDuration8To247().Count());
                        log.Debug("Contains: config.GetDuration8To480().Contains(typeOfService)" + config.GetDuration8To480().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration8To480().Count()" + config.GetDuration8To480().Count());
                        log.Debug("Contains: config.GetDuration8to24Hrs().Contains(typeOfService)" + config.GetDuration8To24Hrs().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration8to24Hrs().Count()" + config.GetDuration8To24Hrs().Count());
                        log.Debug("Contains: config.GetDuration0To24Hrs().Contains(typeOfService)" + config.GetDuration0To24Hrs().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration0To24Hrs().Count()" + config.GetDuration0To24Hrs().Count());
                        log.Debug("Contains: config.GetDuration60To24Hrs().Contains(typeOfService)" + config.GetDuration60To24Hrs().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration60To24Hrs().Count()" + config.GetDuration60To24Hrs().Count());
                        log.Debug("Contains: config.GetDuration8To90().Contains(typeOfService)" + config.GetDuration8To90().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration8To90().Count()" + config.GetDuration8To90().Count());
                        log.Debug("Contains: config.GetDuration8To60().Contains(typeOfService)" + config.GetDuration8To60().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration8To60().Count()" + config.GetDuration8To60().Count());
                        log.Debug("Contains: config.GetDuration1To247().Contains(typeOfService)" + config.GetDuration1To247().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration1To247().Count()" + config.GetDuration1To247().Count());
                        log.Debug("Contains: config.GetDuration1To120().Count()" + config.GetDuration1To120().Count());
                        log.Debug("Contains: config.GetDuration1To120().Contains(typeOfService)" + config.GetDuration1To120().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration15To24Hrs().Count()" + config.GetDuration15To24Hrs().Count());
                        log.Debug("Contains: config.GetDuration15To24Hrs().Contains(typeOfService)" + config.GetDuration15To24Hrs().Contains(typeOfService));
                        log.Debug("Contains: config.GetDuration16To24Hrs().Count()" + config.GetDuration16To24Hrs().Count());
                        log.Debug("Contains: config.GetDuration16To24Hrs().Contains(typeOfService)" + config.GetDuration16To24Hrs().Contains(typeOfService));

                        // ORIGINAL DURATION CHECKS
                        log.Debug("OutPationProgressNote.CheckDuration: typeOfService='" + typeOfService + "'");
                        string errorMessage = validateDuration(typeOfService, durationFieldValue);
                        log.Debug("errorMessage SDJL after validateDuration errorMessage= '" + errorMessage + "'");

                        if (errorMessage != null)
                        {
                            log.Debug("Type Of Service: '" + typeOfService + "'" + " Duration Field Value: '" + durationFieldValue + "'" + "Error Message: '" + errorMessage + "'");
                            returnObject.ErrorCode = 1;
                            returnObject.ErrorMesg = errorMessage;
                        }
                        else
                        {
                            log.Debug("DURATION FIELD VALUE: No Error Found for Type Of Service: " + typeOfService + " Duration Field Value: " + durationFieldValue);
                        }

                        string errorMessageOnCalculatedDuration = validateDuration(typeOfService, calculatedDurationMinutes);
                        if ((errorMessage == null) && (errorMessageOnCalculatedDuration != null))
                        {
                            log.Debug("CALCULATED errorMessageOnCalcuatedDuration - Type Of Service: '" + typeOfService + "'" + " Calculated Duration: '" + calculatedDurationMinutes + "'" + "Error Message: '" + errorMessageOnCalculatedDuration + "'");
                            returnObject.ErrorCode = 1;
                            returnObject.ErrorMesg = errorMessageOnCalculatedDuration;

                        }
                        else if ( (errorMessage == null) && (errorMessageOnCalculatedDuration == null))
                        {
                            log.Debug("No Error Found for Type Of Service: " + typeOfService + " Duration Calculated Minutes: " + durationFieldValue);
                        }



                        // END NEW EXPANDED DURATION CHECKS - 10/20/2021
                        //  NO Duration checks required for this type of service


                        break;

                    default:
                        log.Debug("SDJL - Default Case - Do Nothing: Break");
                        break;

                }

                log.Debug("Test OutpatientProgressNote Debug - 2 SDJL");
                log.Debug("SDJL - END OutPatient ProgressNote RunScript '" + scriptParameter + "'");
                log.Debug("-----------------------------------------");
            }
            catch (Exception e)
            {
                log.Debug("Exception: e" + e.Message);
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

        private string validateDuration(string typeOfService, int durationMinutes)

        {
            OutPatientProgressNoteConfig config = OutPatientProgressNoteConfig.getInstance();
            string retVal = null;


            // ORIGINAL DURATION CHECKS
            log.Debug("OutPationProgressNote.CheckDuration: typeOfService='" + typeOfService + "'");

            if (config.GetDuration16To37().Contains(typeOfService))
            {
                log.Debug("SDJL 90832 - 16<=Duration<=37 Check");
                if ((durationMinutes < 16) || (durationMinutes > 37))
                {
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 16-37 minutes";
                    log.Debug("SDJL 90832 - FAILED 16<=Duration<=37 Check - retVal = '" + retVal + "'");
                    log.Debug("SDJL: " + retVal);

                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 16<=Duration<=37 Check");
                    retVal = null;
                }
            }
            else if (config.GetDuration38To52().Contains(typeOfService))
            {
                log.Debug("SDJL 90834 - 38<=Duration<=52 Check");
                if ((durationMinutes < 38) || (durationMinutes > 52))
                {
                    log.Debug("SDJL 90834 - FAILED 38<=Duration<=52 Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 38-52 minutes";
                    log.Debug("SDJL: " + retVal);
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 38<=Duration<=52 Check");
                }
            }
            else if (config.GetDuration53Plus().Contains(typeOfService))
            {
                log.Debug("SDJL 90837 - Duration < 53 Check");
                if (durationMinutes < 53)
                {
                    log.Debug("SDJL 90837 - FAILED Duration < 53 Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 53+ minutes";
                    log.Debug("SDJL: " + retVal);
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED Duration >= 53 Check");
                }
            }

            // Expanded Duration Checks
            else if (config.GetDuration241To24Hrs().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 241<=Duration<=1440 (24Hrs) Check");
                if ((durationMinutes < 241) || (durationMinutes > 1440))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "Current Duration: " + durationMinutes + "- FAILED 241<=Duration<=1440 (24Hrs) Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 241 - 1440 minutes";
                    log.Debug("SDJL: " + retVal);
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 241<=Duration<=1440 (24Hrs) Check");
                }
            }
            else if (config.GetDuration248To480().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + " Current Duration: " + durationMinutes + "- 248<=Duration<=480 Check");
                if ((durationMinutes < 248) || (durationMinutes > 480))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 248<=Duration<=480 Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 248-480 minutes";
                    log.Debug("SDJL: " + retVal);
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 248<=Duration<=480 Check");
                }
            }
            else if (config.GetDuration248To24Hrs().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 248<=Duration<=1440 (24Hrs) Check");
                if ((durationMinutes < 248) || (durationMinutes > 1440))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 248<=Duration<=1440 (24Hrs) Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 248-1440 minutes";
                    log.Debug("SDJL: " + retVal);
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " - PASSED 248<=Duration<=1440 Check");
                }
            }
            else if (config.GetDuration26To24Hrs().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 26<=Duration<=1440 (24Hrs) Check");
                if ((durationMinutes < 26) || (durationMinutes > 1440))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 26<=Duration<=1440 (24Hrs) Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 26-1440 minutes";
                    log.Debug("SDJL: " + retVal);
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 26<=Duration<=1440 Check");
                }
            }
            else if (config.GetDuration30To74().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 30<=Duration<=74 Check");
                if ((durationMinutes < 30) || (durationMinutes > 74))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 30<=Duration<=74 Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 30-74 minutes";
                    log.Debug("SDJL: " + retVal);
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " - PASSED 30<=Duration<=74 Check");
                }
            }
            else if (config.GetDuration30To24Hrs().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 30<=Duration<=1440 (24Hrs) Check");
                if ((durationMinutes < 30) || (durationMinutes > 1440))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 30<=Duration<=1440 Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 30-1440 minutes";
                    log.Debug("SDJL: " + retVal);
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 30<=Duration<=1440 Check");
                }
            }
            else if (config.GetDuration45To24Hrs().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 45<=Duration<=1440 (24Hrs) Check");
                if ((durationMinutes < 45) || (durationMinutes > 1440))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 45<=Duration<=1440 Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 45-1440 minutes";
                    log.Debug("SDJL: " + retVal);
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " - PASSED 45<=Duration<=1440 Check");
                }
            }
            else if (config.GetDuration53To24Hrs().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 53<=Duration<=1440 (24Hrs) Check");
                if ((durationMinutes < 53) || (durationMinutes > 1440))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 53<=Duration<=1440 Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 53-1440 minutes";
                    log.Debug("SDJL: " + retVal);
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 53<=Duration<=1440 Check");
                }
            }
            else if (config.GetDuration8To240().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 8<=Duration<=240 Check");
                if ((durationMinutes < 8) || (durationMinutes > 240))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 8<=Duration<=240 Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 8-240 minutes";
                    log.Debug("For " + typeOfService + ", Duration must be 8-240 minutes");
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " - PASSED 8<=Duration<=240 Check");
                }
            }
            else if (config.GetDuration8To247().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 8<=Duration<=247 Check");
                if ((durationMinutes < 8) || (durationMinutes > 247))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 8<=Duration<=247 Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 8-247 minutes";
                    log.Debug("SDJL: " + retVal);
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 8<=Duration<=247 Check");
                }
            }
            else if (config.GetDuration8To480().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 8<=Duration<=480 Check");
                if ((durationMinutes < 8) || (durationMinutes > 480))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 8<=Duration<=480 Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 8-480 minutes";
                    log.Debug("SDJL: " + retVal);
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " - PASSED 8<=Duration<=480 Check");
                }
            }
            else if (config.GetDuration8To24Hrs().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 8<=Duration<=1440 (24Hrs) Check");
                if ((durationMinutes < 8) || (durationMinutes > 1440))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 8<=Duration<=1440 (24Hrs) Check");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 8-1440 minutes";
                    log.Debug("SDJL: " + retVal);
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 8<=Duration<=1440 Check");
                }
            }
            else if (config.GetDuration0To24Hrs().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 0<=Duration<=1440 (24Hrs) Check");
                if ((durationMinutes < 0) || (durationMinutes > 1440))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 0<=Duration<=1440 (24Hrs) Check");
                    log.Debug("For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 0-1440 minutes");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 0-1440 minutes";
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 0<=Duration<=1440 (24Hrs) Check");
                }
            }
            else if (config.GetDuration60To24Hrs().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 60<=Duration<=1440 (24Hrs) Check");
                if ((durationMinutes < 60) || (durationMinutes > 1440))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 60<=Duration<=1440 (24Hrs) Check");
                    log.Debug("For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 60-1440 minutes");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 60-1440 minutes";
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 60<=Duration<=1440 (24Hrs) Check");
                }
            }
            else if (config.GetDuration8To90().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 8<=Duration<=90 Check");
                if ((durationMinutes < 8) || (durationMinutes > 90))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 8<=Duration<=90 Check");
                    log.Debug("For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 8-90 minutes");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 8-90 minutes";
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 8<=Duration<=90 Check");
                }
            }
            else if (config.GetDuration8To60().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 8<=Duration<=60 Check");
                if ((durationMinutes < 8) || (durationMinutes > 60))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 8<=Duration<=60 Check");
                    log.Debug("For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 8-60 minutes");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 8-60 minutes";
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 8<=Duration<=60 Check");
                }
            }
            else if (config.GetDuration1To247().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 1<=Duration<=247 Check");
                if ((durationMinutes < 1) || (durationMinutes > 247))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 1<=Duration<=247 Check");
                    log.Debug("For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 1-247 minutes");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 1-247 minutes";
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 1<=Duration<=247 Check");
                }
            }
            else if (config.GetDuration1To120().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 1<=Duration<=120 Check");
                if ((durationMinutes < 1) || (durationMinutes > 120))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 1<=Duration<=120 Check");
                    log.Debug("For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 1-120 minutes");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 1-120 minutes";
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 1<=Duration<=120 Check");
                }
            }
            else if (config.GetDuration15To24Hrs().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 15<=Duration<=1440 (24Hrs) Check");
                if ((durationMinutes < 15) || (durationMinutes > 1440))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 15<=Duration<=1440 Check");
                    log.Debug("For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 15-1440 minutes");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 15-1440 minutes";
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 15<=Duration<=1440 (24Hrs) Check");
                }
            }
            else if (config.GetDuration16To24Hrs().Contains(typeOfService))
            {
                log.Debug("SDJL Expanded Duration Checks: " + typeOfService + "- 16<=Duration<=1440 (24Hrs) Check");
                if ((durationMinutes < 16) || (durationMinutes > 1440))
                {
                    log.Debug("SDJL Expanded Duration Checks " + typeOfService + "- FAILED 16<=Duration<=1440 Check");
                    log.Debug("For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 16-1440 minutes");
                    retVal = "For " + typeOfService + " Current Duration: " + durationMinutes + ", Duration must be 16-1440 minutes";
                }
                else
                {
                    log.Debug("SDJL Expanded Duration Checks ServiceCode: " + typeOfService + " Duration: " + durationMinutes + " - PASSED 16<=Duration<=1440 (24Hrs) Check");
                }
            }
            else
            {
                log.Debug("Service Code was not one of the codes requiring duration check");
            }
            // END NEW EXPANDED DURATION CHECKS - 10/20/2021

            return retVal;
        }

    }
}
