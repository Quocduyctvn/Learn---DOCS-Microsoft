using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie
{
    public class Learn
    {
        // data Annotation(ghi chú dữ liệu)
            // [Key]  => tạo Key chó cột
                    // tạo key cho 2 hay nhiều cột:
                            // [Key]
                            // [Column(Order = 1)]
                            // public int StudentKey { get; set; }
                            // 
                            // [Key]
                            // [Column(Order = 2)]
                            // public int AdmissionNum { get; set; }
            // [Table("table_name")]  => đặt Tên bảng
        // thẻ link:
                    //thuộc tính asp-action="" và asp-controller="" đã tồn tại trong asp.net mvc và tiếp tục sd trong asp.net core mvc
                    // thuộc tính @Html.ActionLink() là method đã tồn ại trong asp.ney và Tiếp tục trong asp.net Mvc

        

//  kiểm soát và xác nhận dữ liệu đầu vào - định dạng dữ liệu,
//  kiểm tra tính hợp lệ của dữ liệu, và đưa ra thông báo lỗi nếu dữ liệu không hợp lệ.
//using System.ComponentModel.DataAnnotations;

//namespace MvcMovie.Models
//    {
//        public class Movie
//        {
//            public int Id { get; set; }
//            public string? Title { get; set; }
//            [DataType(DataType.Date)]
//            public DateTime ReleaseDate { get; set; }// ngay phat hanh
//            public string? Genre { get; set; }       // the loai      -- Cho phép dưx liệu null 
//            public decimal Price { get; set; }
//        }
//    }



}
}
