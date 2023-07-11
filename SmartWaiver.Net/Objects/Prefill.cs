namespace SmartWaiver.Net.Objects
{
    public class Prefill
    {
        public Prefill() { }
        
        /// <summary>
        /// Unique ID of prefilled waiver template
        /// </summary>
        public string UUID { get; set; }
        
        /// <summary>
        /// Expiration time of waiver
        /// </summary>
        public string Expiration { get; set; }
        
        /// <summary>
        /// Direct link to prefilled waiver template
        /// </summary>
        public Uri Url { get; set; }
    }
}
