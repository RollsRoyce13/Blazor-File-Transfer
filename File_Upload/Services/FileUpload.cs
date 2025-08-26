using Microsoft.AspNetCore.Components.Forms;

namespace File_Upload.Services
{
    public interface IFileUpload
    {
        Task UploadFile(IBrowserFile file);
    }

    public class FileUpload : IFileUpload
    {
        private IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<FileUpload> _logger;

        public Task UploadFile(IBrowserFile file)
        {
            throw new NotImplementedException();
        }
    }
}
