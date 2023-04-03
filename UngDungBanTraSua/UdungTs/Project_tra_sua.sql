
use Projec_tra_sua
go
create table tk(
idtk int identity (1000,1) primary key,
hoten nvarchar(max),
email nvarchar(max),
mk nvarchar(max),
sdt nvarchar(max),
diachi nvarchar(max))
go
drop table tk
go
create table danhmuc_sp(
    iddm int identity (1000,1) primary key ,
    tendm nvarchar(max),
    hinhanh nvarchar(max),
	ghichu nvarchar(max)
)
go
create table chon(
    id_l int identity (1000,1) primary key ,
    the_loai nvarchar(max),
    ten nvarchar(max),
	tien nvarchar(max),
	ghichu nvarchar(max)
)
drop table chon
go
create table san_pham(
    idsp int identity (1000,1) primary key ,
	iddm int,
    tensp nvarchar(max),
    giatien nvarchar(max),
	hinhanh nvarchar(max),
	ghichu nvarchar(max)
)
go
create table giohang(
    idgh int identity (1000,1) primary key ,
	idtk int,
	idsp int,
    sl int,
	chon nvarchar(max),
	giax1 nvarchar(max),
    tongtien int,
	ghichu nvarchar(max)
)
drop table giohang

go
create table donhang(
    iddh int identity (1000,1) primary key ,
	idtk int,
	idgh int,
    loinhan nvarchar(max),
	ngaygio nvarchar(max),	
    hanhchinh nvarchar(max),
	ghichu nvarchar(max)
)
drop table donhang
go
select * from donhang
go
select * from giohang


INSERT INTO danhmuc_sp VALUES (N'Món nổi bật',N'https://cdn-icons-png.flaticon.com/128/4645/4645829.png',N'Không');
INSERT INTO danhmuc_sp VALUES (N'Trà sữa',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-13.jpg?alt=media&token=bdc04586-8177-4324-b0e8-898aea8dd442',N'Không');
INSERT INTO danhmuc_sp VALUES (N'Fresh Fruit Tea',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-11.jpg?alt=media&token=5028f169-6a16-4bbf-bea0-50c7390efb4d',N'Không');
INSERT INTO danhmuc_sp VALUES (N'Macchiato Cream Cheese',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/tra%CC%80-xoa%CC%80i-bu%CC%9Bo%CC%9B%CC%89i-ho%CC%82%CC%80ng.png?alt=media&token=f9b28481-5d39-494f-b22f-10d6279ab2bb',N'Không');
INSERT INTO danhmuc_sp VALUES (N'Sữa Chua Dẻo',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/matcha-kem-pho-mai_09b3b54997614aea86d2b61bcd7f548c_73a9e7cd539949718b13b06c5db9522f_grande.png?alt=media&token=89db293b-d462-44e3-a6e0-053256972d3a',N'Không');


INSERT INTO chon VALUES (N'Chọn loại',N'Lạnh','0',N'Không');
INSERT INTO chon VALUES (N'Chọn size',N'Size M','0',N'Không');
INSERT INTO chon VALUES (N'Chọn size',N'Size L','14000',N'Không');
INSERT INTO chon VALUES (N'Chọn size',N'Size LS','24000',N'Không');
INSERT INTO chon VALUES (N'Chọn đường',N'100% đường','0',N'Không');
INSERT INTO chon VALUES (N'Chọn đường',N'70% đường','0',N'Không');
INSERT INTO chon VALUES (N'Chọn đường',N'50% đường','0',N'Không');
INSERT INTO chon VALUES (N'Chọn đường',N'30% đường','0',N'Không');
INSERT INTO chon VALUES (N'Chọn đường',N'Không đường','0',N'Không');
INSERT INTO chon VALUES (N'Chọn đá',N'100% đá','0',N'Không');
INSERT INTO chon VALUES (N'Chọn đá',N'70% đá','0',N'Không');
INSERT INTO chon VALUES (N'Chọn đá',N'50% đá','0',N'Không');
INSERT INTO chon VALUES (N'Chọn đá',N'30% đá','0',N'Không');
INSERT INTO chon VALUES (N'Chọn đá',N'Không đá','0',N'Không');
INSERT INTO chon VALUES (N'Chọn đá',N'Làm ấm','0',N'Không');
INSERT INTO chon VALUES (N'Chọn topping',N'Thêm hạt dẻ','9000',N'9000');
INSERT INTO chon VALUES (N'Chọn topping',N'Thêm trân châu sương mai',N'9000',N'Không');
INSERT INTO chon VALUES (N'Chọn topping',N'Thêm Trân châu Baby',N'8000',N'Không');
INSERT INTO chon VALUES (N'Chọn topping',N'Thêm CreamCake',N'9000',N'Không');
INSERT INTO chon VALUES (N'Chọn topping',N'Thêm trân châu hoàng kim',N'9000',N'Không');
INSERT INTO chon VALUES (N'Chọn topping',N'Thêm thạch băng tuyết',N'9000',N'Không');
INSERT INTO chon VALUES (N'Chọn topping',N'Thêm macchiato',N'8000',N'Không');
INSERT INTO chon VALUES (N'Chọn topping',N'Thêm pudding',N'9000',N'Không');


INSERT INTO san_pham VALUES (1002,N'Trà Xoài Bưởi Hồng',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/tra%CC%80-xoa%CC%80i-bu%CC%9Bo%CC%9B%CC%89i-ho%CC%82%CC%80ng.png?alt=media&token=f9b28481-5d39-494f-b22f-10d6279ab2bb',N'Món nổi bật');
INSERT INTO san_pham VALUES (1003,N'Trà Xoài Bưởi Hồng Kem Phô Mai',N'48000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/tra%CC%80-xoa%CC%80i-bu%CC%9Bo%CC%9B%CC%89i-ho%CC%82%CC%80ng-kem-pho%CC%82-mai.png?alt=media&token=a1f46241-bea8-4e4d-a26a-79bb21afe70f',N'Món nổi bật');
INSERT INTO san_pham VALUES (1003,N'Choco Ngũ Cốc Kem Cafe',N'29000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/Hi%CC%80nh-a%CC%89nh-sp-website_1000x1000_choco-ngu%CC%83-co%CC%82%CC%81c-kem-cafe.png?alt=media&token=6358237c-bf42-44f6-858d-102859828bde',N'Món nổi bật');
INSERT INTO san_pham VALUES (1003,N'Hồng Trà Ngũ Cốc Kem Cafe',N'29000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/Hi%CC%80nh-a%CC%89nh-sp-website_1000x1000_ho%CC%82%CC%80ng-tra%CC%80-ngu%CC%83-co%CC%82%CC%81c-kem-cafe.png?alt=media&token=954dafb7-dd7d-4fd6-898a-da9c029de6be',N'Món nổi bật');
INSERT INTO san_pham VALUES (1000,N'Royal Pearl Milk Coffee',N'29000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/Royal-Pearl-Milk-Coffee.png?alt=media&token=5b028036-0c45-4850-8fc2-de9fe06aeeb3',N'Món nổi bật');
INSERT INTO san_pham VALUES (1000,N'Grass Jelly Milk Coffee',N'29000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/Grass-Jelly-Milk-Coffee.png?alt=media&token=53f0ecf2-d7a5-4f05-bd94-9d302c93ead4',N'Món nổi bật');
INSERT INTO san_pham VALUES (1000,N'Tiger Sugar',N'29000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-12.jpg?alt=media&token=c28862b4-1c51-4601-836b-9d531a6dbb6c',N'Món nổi bật');
INSERT INTO san_pham VALUES (1000,N'Trà Sữa Trân Châu Hoàng Gia',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-10.jpg?alt=media&token=0847818c-8a36-4f40-8d51-1eb08ec4fe7d',N'Món nổi bật');
INSERT INTO san_pham VALUES (1000,N'Choco Creamcake Hạt dẻ',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/choco-creamcake.png?alt=media&token=df88e04c-1e55-499a-89ac-62ac8a5cc2e0',N'Món nổi bật');
INSERT INTO san_pham VALUES (1000,N'Ruby Creamcake Hạt dẻ',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/Hinh-anh-sp-website_ruby-.jpg?alt=media&token=df140237-7eff-4d82-95d4-de7c3a8cb1ea',N'Món nổi bật');
INSERT INTO san_pham VALUES (1000,N'Trà Sữa Ba Anh Em',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/1578305659051_tra_sua_3_anh_em_e5929a819d2c4b08a1ae2caafe921473_grande.jpg?alt=media&token=de8da1dd-7e40-4c8b-9f78-ea2a65806f38',N'Món nổi bật');
INSERT INTO san_pham VALUES (1000,N'Trà Sữa Panda',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-9.jpg?alt=media&token=616608ae-79c8-4710-b9eb-fce62b6661c7',N'Món nổi bật');
INSERT INTO san_pham VALUES (1000,N'Trà Sữa Kim Cương Đen Okinawa',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-21.jpg?alt=media&token=3273dbe6-7eef-4640-9b62-36f0e67cb6fa',N'Món nổi bật');
INSERT INTO san_pham VALUES (1000,N'Trà dứa nhiệt đới',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/tra-dua_02578f0fe1f845379f84dd0aacc05f7b_grande.png?alt=media&token=840769a7-380b-43f4-860c-5f6469fbfd4b',N'Món nổi bật');
INSERT INTO san_pham VALUES (1000,N'Ô Long Kem Phô Mai',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/oolong-kem-pho-mai_75e8d3f11fb3402196416da77c8ff33a_grande.png?alt=media&token=545888a5-384d-4ea3-85e7-5200f813287d',N'Món nổi bật');
INSERT INTO san_pham VALUES (1000,N'Trà Sữa Hạnh Phúc',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-16.jpg?alt=media&token=02f63033-caed-4964-9469-b9509a1afcb5',N'Món nổi bật');
INSERT INTO san_pham VALUES (1004,N'Sữa Chua Dâu Tằm Hoàng Kim',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/sua-chua-dau-tam-hoang-kim.png?alt=media&token=8e5c640a-453b-4baf-b315-33a16459d051',N'không');
INSERT INTO san_pham VALUES (1004,N'Sữa Chua Dâu Tằm Hạt Dẻ',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/sua-chua-dau-tam-hat-de-.png?alt=media&token=edca5786-5cc7-4f15-a3e7-9289821680bc',N'không');
INSERT INTO san_pham VALUES (1004,N'Sữa Chua Trắng',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/sua-chua-trang-.png?alt=media&token=9fd765ae-67bf-452e-924c-c2bcdc10b174',N'không');
INSERT INTO san_pham VALUES (1003,N'Dâu Tằm Kem Phô Mai',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/dau_tam_kem_pho_mai_09a4c4b857694d918a86542225fc2867_grande.jpg?alt=media&token=9766379e-62b4-4915-9e3e-49c5c1d49645',N'không');
INSERT INTO san_pham VALUES (1003,N'Hồng Trà Kem Phô Mai',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/hong_tra_kem_pho_mai_bea768e4679b4a2bbea0d5730fc75ffa_4dbc2f739c184bbbad3cee27aab5cfcd_grande.jpg?alt=media&token=a8a12e3a-ba46-4a07-9975-2f794f01f3ba',N'không');
INSERT INTO san_pham VALUES (1003,N'Trà Xanh Kem Phô Mai',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/tra_xanh_kem_pho_mai_1ed02f821288425d87dd9fc096c62768_40b394e0280f4d55819de201a4405718_grande.jpg?alt=media&token=6a45bf7f-6d42-4d0d-809b-766c074a147d',N'không');
INSERT INTO san_pham VALUES (1003,N'Matcha Kem Phô Mai',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/matcha-kem-pho-mai_09b3b54997614aea86d2b61bcd7f548c_73a9e7cd539949718b13b06c5db9522f_grande.png?alt=media&token=89db293b-d462-44e3-a6e0-053256972d3a',N'không');
INSERT INTO san_pham VALUES (1002,N'Probi Xoài Trân Châu Sương Mai',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-3.jpg?alt=media&token=39732efa-2e2d-4a71-9408-a64c879bf640',N'không');
INSERT INTO san_pham VALUES (1002,N'Chanh Leo Trân Châu Sương Mai',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker.jpg?alt=media&token=6e5567a5-6d8d-420f-86bc-b61ad2be1fad',N'không');
INSERT INTO san_pham VALUES (1002,N'Probi Bưởi Trân Châu Sương Mai',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-2.jpg?alt=media&token=e7ce3785-0e4e-422e-8a52-78a885eead0a',N'không');
INSERT INTO san_pham VALUES (1002,N'Trà Xanh Chanh Leo',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/tra_xanh_chanh_leo_f75be54e6d8e4e9397d7da9f5b1420fc_grande.jpg?alt=media&token=904cf912-3725-42ed-b082-7555d991ec46',N'không');
INSERT INTO san_pham VALUES (1003,N'Trà Xanh Xoài',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/tra_xanh_xoai_35d69664c31248faaf3eeade044035ba_grande.jpg?alt=media&token=d05110f1-4176-4bd8-9e31-67785ae1426c',N'không');
INSERT INTO san_pham VALUES (1003,N'Trà dâu tằm pha lê tuyết',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/da%CC%82u-ta%CC%86%CC%80m-pha-le%CC%82-tuye%CC%82%CC%81t.jpg?alt=media&token=30fbfe36-3f2f-4354-8500-930b09c81fc0',N'không');
INSERT INTO san_pham VALUES (1003,N'Hồng Trà Bưởi Mật Ong',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-7.jpg?alt=media&token=3f91d011-faa5-44e1-838e-8b39df20d227',N'không');
INSERT INTO san_pham VALUES (1001,N'Matcha Đậu Đỏ',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-11.jpg?alt=media&token=5028f169-6a16-4bbf-bea0-50c7390efb4d',N'không');
INSERT INTO san_pham VALUES (1001,N'Sữa Tươi Trân Châu Baby Kem Café',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-6.jpg?alt=media&token=8e1eedb4-07fa-426d-8255-f89be4ee17da',N'không');
INSERT INTO san_pham VALUES (1001,N'Oolong Trân châu Baby Kem Café',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-6.jpg?alt=media&token=8e1eedb4-07fa-426d-8255-f89be4ee17da',N'không');
INSERT INTO san_pham VALUES (1001,N'Trà Xanh',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-13.jpg?alt=media&token=bdc04586-8177-4324-b0e8-898aea8dd442',N'không');
INSERT INTO san_pham VALUES (1001,N'Trà Xanh Sữa Vị Nhài',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-15.jpg?alt=media&token=7e961f53-c75c-4961-8560-ce008b0a8205',N'không');
INSERT INTO san_pham VALUES (1001,N'Trà Sữa Matcha',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-17.jpg?alt=media&token=1fb45b00-1ee8-4c58-8adb-0a9f4e723b46',N'không');
INSERT INTO san_pham VALUES (1001,N'Trà Sữa Ô Long',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-18.jpg?alt=media&token=1fb80bbb-cb34-44bd-978e-11f67095bf0d',N'không');
INSERT INTO san_pham VALUES (1001,N'Ô Long Thái Cực',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-19.jpg?alt=media&token=1eaca19b-d2a8-4055-a4c3-2095fb504403',N'không');
INSERT INTO san_pham VALUES (1001,N'Trà Sữa Khoai Môn Hoàng Kim',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-8.jpg?alt=media&token=23553491-9516-4404-b513-03abae1a5210',N'không');
INSERT INTO san_pham VALUES (1001,N'Hồng Trà',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/1578304012347_hong_tra_f8b228ea2b0147a5b05c9292569deea7_grande.jpg?alt=media&token=e4414ae2-0553-47ab-8f95-6aa8f6da28c7',N'không');
INSERT INTO san_pham VALUES (1001,N'Trà Sữa Socola',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-23.jpg?alt=media&token=4f0a1cee-ad1a-400a-a0d5-96739117285e',N'không');
INSERT INTO san_pham VALUES (1001,N'Trà Sữa Bạc Hà',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/ezgif.com-gif-maker-23.jpg?alt=media&token=4f0a1cee-ad1a-400a-a0d5-96739117285e',N'không');
INSERT INTO san_pham VALUES (1001,N'Trà sữa dâu tây',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/Hinh-anh-sp-website_tra-sua-dau-tay.png?alt=media&token=6b133ba7-e27b-4b50-90b8-9ef36fd8f6a4',N'không');
INSERT INTO san_pham VALUES (1001,N'Trà sữa',N'38000',N'https://firebasestorage.googleapis.com/v0/b/test1-581e3.appspot.com/o/1578305659051_tra_sua_3_anh_em_e5929a819d2c4b08a1ae2caafe921473_grande.jpg?alt=media&token=de8da1dd-7e40-4c8b-9f78-ea2a65806f38',N'không');


