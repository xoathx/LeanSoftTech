using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LeanSoftTech.Models
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Person
    {
		[JsonPropertyName("id")]
		public Int32 Id { get; set; }
		[JsonPropertyName("transportId")]
		public Guid TransportId { get; set; }
		[JsonPropertyName("firstName")]
		public String FirstName { get; set; }
		[JsonPropertyName("lastName")]
		public String LastName { get; set; }
		[JsonPropertyName("sequenceId")]
		public Int32 SequenceId { get; set; }
		[JsonPropertyName("creditCardNumbers")]
		public String[] CreditCardNumbers { get; set; }
		[JsonPropertyName("age")]
		public Int32 Age { get; set; }
		[JsonPropertyName("phones")]
		public String[] Phones { get; set; }
		[JsonPropertyName("birthDate")]
		public Int64 BirthDate { get; set; }
		[JsonPropertyName("salary")]
		public Double Salary { get; set; }
		[JsonPropertyName("isMarred")]
		public Boolean IsMarred { get; set; }
		[JsonPropertyName("gender")]
		public Gender Gender { get; set; }
		[JsonPropertyName("children")]
		public Child[] Children { get; set; }
    }
}
