using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Assignment_1.Data;
using Assignment_2.Data.Impl;

namespace Models {
public class Adult : Person {
    
    [JsonPropertyName("jobTitle")]
    public string JobTitle { get; set; }
    
    
    public override string ToString() {
        return JsonSerializer.Serialize(this);
    }
    
    public void Update(Adult toUpdate) {
        JobTitle = toUpdate.JobTitle;
        base.Update(toUpdate);
    }

}
}