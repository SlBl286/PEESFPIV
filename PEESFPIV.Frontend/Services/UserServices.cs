// using PEESFPIV.Frontend.Databases.Repositories.Interfaces;

// namespace PEESFPIV.Frontend.Services;

// public sealed class UserServices {
//     private readonly IUserRepository _userRepository;

//     public UserServices(IUserRepository userRepository)
//     {
//         _userRepository = userRepository;
//     }
//     public async Task CreateOrUpdateAsync()
//     {
//         if (User is not null)
//         {
//             var userExisted = await _userRepository.GetUserByUsername(Model.Username);
//             if (userExisted is not null)
//             {
//                 if (userExisted.Id != User.Id)
//                 {
//                     ErrorMessage = "Tên tài khoản đã đươc sử dụng";
//                     ToastService.Notify(new(ToastType.Danger, $"Lỗi: {ErrorMessage}."));
//                     return;
//                 }
//             }
//             User.Username = Model.Username;
//             User.Name = Model.Name;
//             User.RoleId = Model.RoleId;
//             if (Model.Password != User.Salt)
//             {
//                 byte[] salt = [];
//                 var hashedPassword = _hashString.HashPassword(Model.Password, out salt);
//                 User.HashedPassword = hashedPassword;
//                 User.Salt = Convert.ToBase64String(salt);
//             }
//             var oldAvatarPath = User.Avatar;
//             if(Model.Avatar is not null){
//                 var saveFolder = Path.Combine(_env.ContentRootPath,"wwwroot","uploads","users");
//                 var fileName = Path.GetFileNameWithoutExtension(Model.Avatar.Name)+"_"+Path.GetRandomFileName()+Path.GetExtension(Model.Avatar.Name);
//                 var filePath = Path.Combine(saveFolder,fileName);
//                 Directory.CreateDirectory(saveFolder);
//                 await using FileStream fs = new(filePath, FileMode.Create);
//                 await  Model.Avatar.OpenReadStream().CopyToAsync(fs); 
//                 User.Avatar = Path.Combine("uploads","users",fileName);
//             }

//             await _userRepository.Update(User);
//             if(oldAvatarPath is not null){
//                 var saveFolder = Path.Combine(_env.ContentRootPath,"wwwroot");
//                 var filePath = Path.Combine(saveFolder, oldAvatarPath);
//                 if(File.Exists(filePath)){
//                     File.Delete(filePath);
//                 }
//             }
//             await ParentModal.HideAsync();
//             ToastService.Notify(new(ToastType.Success, $"Cập nhật tài khoản [{User.Username}] thành công."));

//         }
//         else
//         {
//             var userExisted = await _userRepository.GetUserByUsername(Model.Username);
//             if (userExisted is not null)
//             {
//                 ErrorMessage = "Tài khoản đã tồn tại";
//                 ToastService.Notify(new(ToastType.Danger, $"Lỗi: {ErrorMessage}."));
//                 return;
//             }
//             string? avatarPath =null;
//             if(Model.Avatar is not null){
//                 var saveFolder = Path.Combine(_env.ContentRootPath,"wwwroot","uploads","users");
//                 var fileName = Path.GetFileNameWithoutExtension(Model.Avatar.Name)+"_"+Path.GetRandomFileName()+Path.GetExtension(Model.Avatar.Name);
//                 var filePath = Path.Combine(saveFolder, fileName);
//                 Directory.CreateDirectory(saveFolder);

//                 await using FileStream fs = new(filePath, FileMode.Create);
//                 await  Model.Avatar.OpenReadStream().CopyToAsync(fs); 
//                 avatarPath =  Path.Combine("uploads","users", fileName);
//             }
//             byte[] salt = [];
//             var hashedPassword = _hashString.HashPassword(Model.Password, out salt);
//             var user = new User
//                 {
//                     Id = Guid.NewGuid(),
//                     Username = Model.Username,
//                     Name = Model.Name,
//                     HashedPassword = hashedPassword,
//                     RoleId = Model.RoleId,
//                     Avatar = avatarPath,
//                     Salt = Convert.ToBase64String(salt)
//                 };
//             await _userRepository.Add(user);
//             await ParentModal.HideAsync();
//             ToastService.Notify(new(ToastType.Success, $"Tạo tài khoản [{user.Username}] thành công."));
//         }

//     }


// }