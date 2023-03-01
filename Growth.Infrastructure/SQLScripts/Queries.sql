select * from Users
select * from Users join Addresses on Users.Id = Addresses.UserId
select * from Users join Cars on Users.Id = Cars.UserId
select * from Users inner join UserInternetShop on Users.Id = UserInternetShop.UserId join InternetShops on UserInternetShop.InternetShopId = InternetShops.Id
