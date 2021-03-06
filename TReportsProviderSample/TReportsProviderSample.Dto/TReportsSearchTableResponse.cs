﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TReportsProviderSample.Dto
{
  public class TReportsSearchTableResponse : TReportsResponseBase
  {
    [JsonProperty("hasNext")]
    public bool HasNext { get; set; }
   
    [JsonProperty("searchTables")]
    public List<SearchTable> SearchTables { get; set; }

  }

  public partial class SearchTable
  {
    [JsonProperty("tableSourceName")]
    public string TableSourceName { get; set; }

    [JsonProperty("tableSourceDescription")]
    public string TableSourceDescription { get; set; }
  }
}
