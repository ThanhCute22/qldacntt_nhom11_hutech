using System.ComponentModel.DataAnnotations;

namespace WebsiteBanHang.Models.QuanLyLienHe
{
    public class LienHeViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Họ và tên phải từ 2 đến 100 ký tự")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập email")]
        [EmailAddress(ErrorMessage = "Vui lòng nhập email hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "Số điện thoại phải là 10 hoặc 11 số")]
        public string SoDienThoai { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Nội dung phải từ 10 đến 1000 ký tự")]
        public string NoiDung { get; set; }
    }
}
