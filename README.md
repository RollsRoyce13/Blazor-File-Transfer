# 🚀 Blazor File Upload & Download Demo

A modern Blazor Server app for uploading and downloading files with preview support. Built on .NET 8.  
Easily upload images and PDFs, view previews, and download files with a single click!  

## ✨ Features

- 📤 **Upload multiple files** (images, PDFs) with progress bar
- 🖼️ **Preview uploaded images** instantly
- 📄 **PDF preview** with custom icon
- 📥 **Download files** directly from the browser
- ⚡ Built with Blazor Server (.NET 8)

## 🛠️ Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Modern browser (Edge, Chrome, Firefox, etc.)


## 📚 Usage

- Go to the **Home** page (`/`)
- Select one or more files to upload
- Click **Upload** to send files to the server
- View image previews and upload progress

- Go to the **Downloads** page (`/downloads`)
- See all uploaded files
- Preview images and PDFs
- Click **Download** to save files locally

## 🏗️ Project Structure

- `Components/Pages/Home.razor` – File upload UI & logic
- `Components/Pages/Downloads.razor` – File download & preview UI
- `Services/FileDownload.cs` – File download service
- `wwwroot/js/CustomScripts.js` – JavaScript for file download
- `wwwroot/uploads/` – Uploaded files storage

---

Made with ❤️ using Blazor & .NET 8
