﻿using System.Collections.Generic;

namespace Raven.Imports.Newtonsoft.Json.Tests.TestObjects
{
  public class HolderClass
  {
    public HolderClass() { }

    [Newtonsoft.Json.JsonProperty(TypeNameHandling = Raven.Imports.Newtonsoft.Json.TypeNameHandling.All)]
    public ContentBaseClass TestMember { get; set; }

    [Newtonsoft.Json.JsonProperty(TypeNameHandling = Raven.Imports.Newtonsoft.Json.TypeNameHandling.All)]
    public Dictionary<int, IList<ContentBaseClass>> AnotherTestMember { get; set; }

    public ContentBaseClass AThirdTestMember { get; set; }

  }
}
