
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyWithValidations.Models;




public class Survey{

[Required]
[MinLength(3)]
[Display(Name = "Your Username:")]
public string Name {get;set;}
[Required]
public string Location{get;set;}
[Required]
public string Language{get;set;}

public string Comment{get;set;}


    
}
