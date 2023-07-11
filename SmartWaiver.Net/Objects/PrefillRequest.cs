using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class PrefillRequest
    {
        public PrefillRequest() { }

        /// <summary>
        /// Expiration in seconds of waiver template (required)
        /// </summary>
        [JsonProperty(PropertyName = "expiration")]
        public int Expiration { get; set; }
        
        /// <summary>
        /// Whether to use kiosk mode
        /// </summary>
        [JsonProperty(PropertyName = "kiosk")]
        public bool? Kiosk { get; set; }
        
        /// <summary>
        /// Whether the waiver has only an adult or also a child
        /// </summary>
        [JsonProperty(PropertyName = "adult")]
        public bool? Adult { get; set; }

        /// <summary>
        /// Hide the anyone else need to sign buttons(Allowed types: true or false), (Default: false)
        /// </summary>
        [JsonProperty(PropertyName = "anyoneElseHidden")]
        public bool? AnyoneElseHidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "participants")]
        public List<Participant> Participants { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "guardian")]
        public Guardian Guardian { get; set; }
        
        /// <summary>
        /// Address waiver question Line One
        /// </summary>
        [JsonProperty(PropertyName = "addressLineOne")]
        public string AddressLineOne { get; set; }
        
        /// <summary>
        /// Address waiver question Line Two
        /// </summary>
        [JsonProperty(PropertyName = "addressLineTwo")] 
        public string AddressLineTwo { get; set; }
        
        /// <summary>
        /// Address waiver question City
        /// </summary>
        [JsonProperty(PropertyName = "addressCity")] 
        public string AddressCity { get; set; }
        
        /// <summary>
        /// Address waiver question country
        /// </summary>
        [JsonProperty(PropertyName = "addressCountry")]
        public string AddressCountry { get; set; }
        
        /// <summary>
        /// Address waiver question state
        /// </summary>
        [JsonProperty(PropertyName = "addressState")]
        public string AddressState { get; set; }
        
        /// <summary>
        /// Address waiver question zip code
        /// </summary>
        [JsonProperty(PropertyName = "addressZip")]
        public string AddressZip { get; set; }
        
        /// <summary>
        /// Email waiver question
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        
        /// <summary>
        /// Emergency waiver question name
        /// </summary>
        [JsonProperty(PropertyName = "emergencyContactName")]
        public string EmergencyContactName { get; set; }
        
        /// <summary>
        /// Emergency waiver question phone
        /// </summary>
        [JsonProperty(PropertyName = "emergencyContactPhone")]
        public string EmergencyContactPhone { get; set; }
        
        /// <summary>
        /// Insurance carrier
        /// </summary>
        [JsonProperty(PropertyName = "insuranceCarrier")]
        public string InsuranceCarrier { get; set; }
        
        /// <summary>
        /// Policy number
        /// </summary>
        [JsonProperty(PropertyName = "insurancePolicyNumber")]
        public string InsurancePolicyNumber { get; set; }
        
        /// <summary>
        /// Drivers License State
        /// </summary>
        [JsonProperty(PropertyName = "driversLicenseState")]
        public string DriversLicenseState { get; set; }
        
        /// <summary>
        /// Drivers License Number
        /// </summary>
        [JsonProperty(PropertyName = "driversLicenseNumber")]
        public string DriversLicenseNumber { get; set; }
        
        /// <summary>
        /// Custom waiver fields on the waiver
        /// </summary>
        [JsonProperty(PropertyName = "customWaiverFields")]
        public Dictionary<string, string> CustomWaiverFields { get; set; }

    }
}
