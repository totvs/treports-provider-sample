﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TReportsProviderSample.Dto
{
  public class TReportsRelationRequest : TReportsRequestBase
  {
    [JsonProperty("parentTableName")]
    public string ParentTableName { get; set; }

    [JsonProperty("childTableName")]
    public string ChildTableName { get; set; }
  }
}
