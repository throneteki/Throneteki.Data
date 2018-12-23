namespace CrimsonDev.Throneteki.Data.Models
{
    public class ThronetekiSettings
    {
        public bool? PromptDupes { get; set; }
        public KeywordSettings KeywordSettings { get; set; }
        public TimerSettings TimerSettings { get; set; }
        public ActionWindowSettings PromptedActionWindows { get; set; }
    }
}