namespace Mango.Services.ProductAPI.Models.Dtos
{
    public class ResponseDto
    {
        public bool isSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DisplayMessage { get; set; } = "";
        public List<String> ErrorMessages { get; set; }
    }
}
