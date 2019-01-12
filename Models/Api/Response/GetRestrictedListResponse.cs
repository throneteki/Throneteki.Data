namespace CrimsonDev.Throneteki.Data.Models.Api
{
    using System.Collections.Generic;
    using CrimsonDev.Gameteki.Data.Models.Api;

    public class GetRestrictedListResponse : ApiResponse
    {
        public List<ApiRestrictedListEntry> RestrictedList { get; set; }
    }
}