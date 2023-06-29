using System.ComponentModel.DataAnnotations;
namespace  BaithiPTK1062.Models;
public class PTKCau3
{
    [Key]

    [Display(Name = "Họ Và Tên")]
    public string hovaten{get;set;}


    [Display(Name = "Địa chỉ")]

    public string diachi{get;set;}
    

    [Display(Name = "Số Điện Thoại")]

    public string sodienthoai{get;set;}

}
