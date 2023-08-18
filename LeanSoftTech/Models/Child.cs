using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LeanSoftTech.Models
{

    public class Child
    {
		[JsonPropertyName("id")]
		public Int32 Id { get; set; }
		[JsonPropertyName("firstName")]
		public String FirstName { get; set; }
		[JsonPropertyName("lastName")]
		public String LastName { get; set; }
		[JsonPropertyName("birthDate")]
		public Int64 BirthDate { get; set; }
		[JsonPropertyName("gender")]
		public Gender Gender { get; set; }
    }
}
