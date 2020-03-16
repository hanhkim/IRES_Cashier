INSERT INTO "item_category" ("item_category_id", "restaurant_id", "category_code", "category_name", "category_status", "category_description", "created_by", "created_datetime", "updated_by", "updated_datetime", "active", "version") VALUES
	(1, 1, E'GIA_CAM', E'Gia cầm', E'ACTIVE', E'Gia cầm', E'Script', E'2019-11-22 10:14:53+07', E'Script', E'2019-11-22 10:14:55+07', E'true', 0),
	(2, 1, E'GIA_SUC', E'Gia súc', E'ACTIVE', E'Gia súc', E'Script', E'2019-11-22 10:15:10+07', E'Script', E'2019-11-22 10:15:09+07', E'true', 0),
	(3, 1, E'HAI_SAN', E'Hải sản', E'ACTIVE', E'Hải sản', E'Script', E'2019-11-22 10:16:02+07', E'Script', E'2019-11-22 10:16:04+07', E'true', 0),
	(4, 1, E'RAU_CU', E'Rau củ', E'ACTIVE', E'Rau củ', E'Script', E'2019-11-22 10:16:32+07', E'Script', E'2019-11-22 10:16:34+07', E'true', 0),
	(5, 1, E'TRUNG', E'Trứng', E'ACTIVE', E'Trứng', E'Script', E'2019-11-22 10:17:03+07', E'Script', E'2019-11-22 10:17:05+07', E'true', 0),
	(6, 1, E'GAO', E'Gạo', E'ACTIVE', E'Gạo', E'Script', E'2019-11-22 10:48:48+07', E'Script', E'2019-11-22 10:48:49+07', E'true', 0);

INSERT INTO "uom" ("uom_id", "uom_code", "uom_name", "uom_status", "uom_description", "created_by", "created_datetime", "updated_by", "updated_datetime", "active", "version") VALUES
	(1, E'KG', E'Kg', E'ACTIVE', E'Kilogram', E'Script', E'2019-11-22 11:07:02+07', E'Script', E'2019-11-22 11:07:04+07', E'true', 0),
	(2, E'CON', E'Con', E'ACTIVE', E'Con', E'Script', E'2019-11-22 11:07:18+07', E'Script', E'2019-11-22 11:07:21+07', E'true', 0),
	(3, E'QUA', E'Quả', E'ACTIVE', E'Quả', E'Script', E'2019-11-22 11:07:37+07', E'Script', E'2019-11-22 11:07:38+07', E'true', 0),
	(4, E'CU', E'Củ', E'ACTIVE', E'Củ', E'Script', E'2019-11-22 11:07:49+07', E'Script', E'2019-11-21 11:07:50+07', E'true', 0),
	(5, E'CAI', E'Cái', E'ACTIVE', E'Cái', E'Script', E'2019-11-22 11:08:17+07', E'Script', E'2019-11-22 11:08:23+07', E'true', 0);

INSERT INTO "item" ("item_id", "restaurant_id", "item_code", "item_name", "item_toloren", "item_status", "item_description", "created_by", "created_datetime", "updated_by", "updated_datetime", "active", "version", "item_category_id") VALUES
	(1, 1, E'I-0001', E'Bắp cải', 0.12, E'ACTIVE', E'Bắp cải', E'Script', E'2019-11-22 10:18:09+07', E'Script', E'2019-11-22 10:18:11+07', E'true', 0, 4),
	(2, 1, E'I-0002', E'Thịt heo', 0.12, E'ACTIVE', E'Thịt heo', E'Script', E'2019-11-22 10:19:30+07', E'Script', E'2019-11-22 10:19:34+07', E'true', 0, 2),
	(3, 1, E'I-0003', E'Thịt bò', 0.12, E'ACTIVE', E'Thịt bò', E'Script', E'2019-11-22 10:19:55+07', E'Script', E'2019-11-22 10:21:56+07', E'true', 0, 2),
	(4, 1, E'I-0004', E'Trứng gà', 0.12, E'ACTIVE', E'Trứng gà', E'Script', E'2019-11-22 10:21:40+07', E'Script', E'2019-11-22 10:21:54+07', E'true', 0, 5),
	(5, 1, E'I-0005', E'Cà chua', 0.12, E'ACTIVE', E'Cà chua', E'Script', E'2019-11-22 10:21:38+07', E'Script', E'2019-11-22 10:21:53+07', E'true', 0, 4),
	(6, 1, E'I-0006', E'Ớt hiểm', 0.12, E'ACTIVE', E'Ớt hiểm', E'Script', E'2019-11-21 10:21:36+07', E'Script', E'2019-11-23 10:21:50+07', E'true', 0, 4),
	(7, 1, E'I-0007', E'Rau muống', 0.12, E'ACTIVE', E'Rau muống', E'Script', E'2019-11-23 10:21:35+07', E'Script', E'2019-11-22 10:21:49+07', E'true', 0, 4),
	(8, 1, E'I-0008', E'Thịt gà', 0.12, E'ACTIVE', E'Thịt gà', E'Script', E'2019-11-22 10:23:21+07', E'Script', E'2019-11-22 10:23:23+07', E'true', 0, 1),
	(9, 1, E'I-0009', E'Tôm sú', 0.12, E'ACTIVE', E'Tôm sú', E'Script', E'2019-11-22 10:23:51+07', E'Script', E'2019-11-22 10:23:53+07', E'true', 0, 3),
	(10, 1, E'I-0010', E'Bắp bò', 0.12, E'ACTIVE', E'Bắp bò', E'Script', E'2019-11-22 10:47:53+07', E'Script', E'2019-11-22 10:47:54+07', E'true', 0, 4),
	(11, 1, E'I-0011', E'Ngó sen', 0.12, E'ACTIVE', E'Ngó sen', E'Script', E'2019-11-22 10:48:23+07', E'Script', E'2019-11-22 10:48:24+07', E'true', 0, 4),
	(12, 1, E'I-0012', E'Hành tím', 0.12, E'ACTIVE', E'Hành tím', E'Script', E'2019-11-22 10:49:24+07', E'Script', E'2019-11-22 10:49:25+07', E'true', 0, 4),
	(13, 1, E'I-0013', E'Gạo nếp', 0.12, E'ACTIVE', E'Gạo nếp', E'Script', E'2019-11-22 10:49:57+07', E'Script', E'2019-11-22 10:49:59+07', E'true', 0, 6);


INSERT INTO "combo" ("combo_id", "combo_code", "combo_name", "combo_image", "combo_price", "combo_start_date", "combo_end_date", "combo_quantity", "combo_type", "combo_status", "combo_description", "combo_note", "created_by", "created_datetime", "updated_by", "updated_datetime", "active", "version") VALUES
	(1, E'C-000001', E'combo so 01', E'https://www.hoteljob.vn/files/Anh-Hoteljob-Ni/Nam-2019/Thang-6/Bo-sung-3/combo-la-gi-03.jpg', 500000, E'2019-11-30', E'2020-12-28', 120, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, E'true', 0),
	(2, E'C-000002', E'combo so 02', E'https://vitquaytothi.com.vn/wp-content/uploads/2019/06/combo-nha-hang-to-thi-4.jpg', 500000, E'2019-11-29', E'2020-12-28', 100, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, E'true', 0),
	(3, E'C-000003', E'combo so 03', E'http://changkangkung.com.vn/assets/upload/changkangkung.com.vn/res/CTKM/4-combo-mo%CC%9B%CC%81i-2.png', 500000, E'2019-11-24', E'2020-12-28', 180, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, E'true', 0),
	(4, E'C-000004', E'combo so 04', E'https://littletokyo.vn/wp-content/uploads/2019/02/crazy-combo-little-tokyo-in-danang-8.jpg', 500000, E'2019-11-28', E'2020-12-28', 120, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, E'true', 0);

INSERT INTO "promotion" ("promotion_id", "restaurant_id", "promotion_code", "promotion_apply_type", "promotion_start_date", "promotion_end_date", "promotion_quantity", "promotion_value", "promotion_max_value", "promotion_unit", "promotion_condition", "promotion_description", "created_by", "created_datetime", "updated_by", "updated_datetime", "active", "version") VALUES
	(1, NULL, E'KHUYENMAI01', E'ALL', E'2019-09-27', E'2019-10-01', NULL, E'100000', 100000, E'VNĐ', NULL, E'Giảm giá 100,000VNĐ đối với khách hàng nhập mã khuyến mãi là KHUYENMAI01', E'Script', E'2019-09-29 11:56:12+07', E'Script', E'2019-09-29 11:56:14+07', E'true', 0),
	(2, NULL, E'KHUYENMAI02', E'CUSTOMER', E'2019-09-26', E'2019-10-01', NULL, E'40', 500000, E'%', E'Level bạc', E'Giảm giá 40% tổng hóa đơn tối đa 500,000VNĐ', E'Script', E'2019-09-29 11:57:31+07', E'Script', E'2019-09-29 11:57:33+07', E'true', 0);

INSERT INTO "sale_off" ("sale_off_id", "sale_off_code", "sale_off_name", "sale_off_price", "sale_off_start_date", "sale_off_end_date", "sale_off_quantity", "sale_off_type", "sale_off_status", "sale_off_description", "sale_off_note", "created_by", "created_datetime", "updated_by", "updated_datetime", "active", "version") VALUES
	(1, E'S-001', E'Sale of 01', 50000, E'2019-12-01', E'2020-12-15', 120, NULL, E'ACTIVE', NULL, NULL, NULL, E'2019-12-01 09:56:17+07', NULL, E'2019-12-01 09:56:17+07', E'true', 0),
	(2, E'S-002', E'Sale of 02', 50000, E'2019-12-01', E'2020-12-15', 120, NULL, E'ACTIVE', NULL, NULL, NULL, NULL, NULL, NULL, E'true', NULL),
	(3, E'S-003', E'Sale of 03', 50000, E'2019-12-01', E'2020-12-15', 120, NULL, E'ACTIVE', NULL, NULL, NULL, NULL, NULL, NULL, E'true', NULL);

INSERT INTO "table_info" ("table_id", "table_code", "table_number", "table_position", "table_status", "table_description", "created_by", "created_datetime", "updated_by", "updated_datetime", "active", "version") VALUES
	(2, E'TABLE-02', 2, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 2 Tầng 1', E'Script', E'2019-09-29 12:01:18+07', E'Script', E'2019-09-29 12:01:20+07', E'true', 0),
	(3, E'TABLE-03', 3, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 3 Tầng 1', E'Script', E'2019-09-29 12:01:18+07', E'Script', E'2019-09-29 12:01:20+07', E'true', 0),
	(4, E'TABLE-04', 4, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 4 Tầng 1', E'Script', E'2019-09-29 12:01:18+07', E'Script', E'2019-09-29 12:01:20+07', E'true', 0),
	(5, E'TABLE-05', 5, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 5 Tầng 1', E'Script', E'2019-09-29 12:01:18+07', E'Script', E'2019-09-29 12:01:20+07', E'true', 0),
	(6, E'TABLE-06', 1, E'Tầng 2', E'CÒN TRỐNG', E'Bàn 1 Tầng 2', E'Script', E'2019-09-29 12:03:15+07', E'Script', E'2019-09-29 12:03:17+07', E'true', 0),
	(7, E'TABLE-07', 2, E'Tầng 2', E'CÒN TRỐNG', E'Bàn 2 Tầng 2', E'Script', E'2019-09-29 12:03:15+07', E'Script', E'2019-09-29 12:03:17+07', E'true', 0),
	(8, E'TABLE-08', 3, E'Tầng 2', E'CÒN TRỐNG', E'Bàn 3 Tầng 2', E'Script', E'2019-09-29 12:03:15+07', E'Script', E'2019-09-29 12:03:17+07', E'true', 0),
	(10, E'TABLE-10', 5, E'Tầng 2', E'CÒN TRỐNG', E'Bàn 5 Tầng 2', E'Script', E'2019-09-29 12:03:15+07', E'Script', E'2019-09-29 12:03:17+07', E'true', 0),
	(9, E'TABLE-09', 4, E'Tầng 2', E'CÒN TRỐNG', E'Bàn 4 Tầng 2', E'Script', E'2019-09-29 12:03:15+07', E'Script', E'2019-09-29 12:03:17+07', E'true', 0),
	(24, E'TABLE-24', 19, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(25, E'TABLE-25', 20, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(26, E'TABLE-26', 21, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(27, E'TABLE-27', 22, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(28, E'TABLE-28', 23, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(29, E'TABLE-29', 24, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(30, E'TABLE-30', 25, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(1, E'TABLE-01', 1, E'Tầng 1', E'ĐANG DÙNG', E'Bàn 1 Tầng 1', E'Script', E'2019-09-29 12:00:42+07', E'Script', E'2020-02-05 23:48:01.037+07', E'true', 1),
	(11, E'TABLE-11', 6, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 6 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', E'2020-02-05 23:10:29+07', E'true', 0),
	(12, E'TABLE-12', 7, E'Tầng 2', E'CÒN TRỐNG', E'Bàn 7 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(13, E'TABLE-13', 8, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 8 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(14, E'TABLE-14', 9, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 9 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(15, E'TABLE-15', 10, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(16, E'TABLE-16', 11, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(17, E'TABLE-17', 12, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(18, E'TABLE-18', 13, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(19, E'TABLE-19', 14, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(20, E'TABLE-20', 15, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(21, E'TABLE-21', 16, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(22, E'TABLE-22', 17, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0),
	(23, E'TABLE-23', 18, E'Tầng 1', E'CÒN TRỐNG', E'Bàn 10 Tầng 1', E'Script', E'2020-02-05 23:10:27+07', E'Script', NULL, E'true', 0);

INSERT INTO "dish_category" ("dish_category_id", "restaurant_id", "category_code", "category_name", "category_status", "category_description", "created_by", "created_datetime", "updated_by", "updated_datetime", "active", "version") VALUES
	(1, 1, E'D-0001', E'Món bò', E'ACTIVE', E'Món bò', E'Script', E'2019-11-22 10:26:00+07', E'Script', E'2019-11-22 10:26:02+07', E'true', 0),
	(2, 1, E'D-0002', E'Món gà', E'ACTIVE', E'Món gà', E'Script', E'2019-11-22 10:26:46+07', E'Script', E'2019-11-22 10:26:48+07', E'true', 0),
	(3, 1, E'D-0003', E'Món gỏi', E'ACTIVE', E'Món gỏi', E'Script', E'2019-11-22 10:27:09+07', E'Script', E'2019-11-22 10:27:11+07', E'true', 0),
	(4, 1, E'D-0004', E'Món cơm', E'ACTIVE', E'Món cơm', E'Script', E'2019-11-22 10:27:31+07', E'Script', E'2019-11-22 10:27:33+07', E'true', 0),
	(5, 1, E'D-0005', E'Món súp', E'ACTIVE', E'Món súp', E'Script', E'2019-11-22 10:35:49+07', E'Script', E'2019-11-22 10:35:51+07', E'true', 0),
	(6, 1, E'D-0006', E'Món xôi', E'ACTIVE', E'Món xôi', E'Script', E'2019-11-22 10:37:24+07', E'Script', E'2019-11-22 10:37:26+07', E'true', 0),
	(7, 1, E'D-0007', E'Món lẩu', E'ACTIVE', E'Món lẩu', E'Script', E'2020-02-06 18:39:31+07', E'Script', E'2020-02-06 18:39:31+07', E'true', 0),
	(8, 1, E'D-0008', E'Tráng miệng', E'ACTIVE', E'Tráng miệng', E'Script', E'2020-02-06 18:40:14+07', E'Script', E'2020-02-06 18:40:15+07', E'true', 0);

INSERT INTO "dish" ("dish_id", "restaurant_id", "dish_code", "dish_name", "image_url", "dish_cost", "dish_type", "dish_category_id", "combo_id", "sale_off_id", "dish_status", "dish_description", "created_by", "created_datetime", "updated_by", "updated_datetime", "active", "version") VALUES
	(11, 1, E'D-0011', E'Xôi mặn', E'https://anh.eva.vn/upload/1-2017/images/2017-02-14/1487058876-cach-lam-xoi-man-thap-cam.jpg', 50000, E'KHAI VỊ', 6, 3, NULL, E'ACTIVE', E'Xôi mặn', E'Script', E'2019-11-22 10:37:55+07', E'Script', E'2019-11-22 10:37:56+07', E'true', 0),
	(12, 1, E'D-0012', E'Xôi vò', E'https://media.ex-cdn.com/EXP/media.phunutoday.vn/files/upload_images/2016/01/08/cach-lam-xoi-co-3-phunutoday_vn.jpg', 50000, E'KHAI VỊ', 6, 4, NULL, E'ACTIVE', E'Xôi vò', E'Script', E'2019-11-22 10:38:25+07', E'Script', E'2019-11-22 10:38:27+07', E'true', 0),
	(8, 1, E'D-0008', E'Gỏi rau muống thịt bò', E'http://www.savourydays.com/wp-content/uploads/2015/07/GoiThitBoRauMuongMam1.jpg', 80000, E'KHAI VỊ', 3, NULL, NULL, E'ACTIVE', E'Gỏi rau muống thịt bò', E'Script', E'2019-11-22 10:34:27+07', E'Script', E'2019-11-22 10:34:34+07', E'true', 0),
	(1, 1, E'D-0001', E'Bò xào cà chua', E'http://www.monngon.tv/uploads/images/2017/06/20/64a1ef44e058f2d1a38d4649ae65aa1a-bo-xao-ca-chua-sl.jpg', 80000, E'MÓN CHÍNH', 1, 1, NULL, E'ACTIVE', E'Bò xào cà chua', E'Script', E'2019-11-22 10:25:21+07', E'Script', E'2019-11-22 10:25:23+07', E'true', 0),
	(7, 1, E'D-0007', E'Gỏi đu đủ', E'https://monngonmoingay.com/wp-content/uploads/2015/08/IMG-0031-goi-du-du.png', 80000, E'KHAI VỊ', 3, 2, NULL, E'ACTIVE', E'Gỏi đu đủ', E'Script', E'2019-11-22 10:32:54+07', E'Script', E'2019-11-22 10:32:56+07', E'true', 0),
	(9, 1, E'D-0009', E'Súp rau thập cẩm', E'https://toinayangi.vn/wp-content/uploads/2015/03/sup-thap-cam-thom-ngon-bo-duong-01.jpg', 50000, E'KHAI VỊ', 5, 3, NULL, E'ACTIVE', E'Súp rau thập cẩm', E'Script', E'2019-11-22 10:35:17+07', E'Script', E'2019-11-22 10:35:19+07', E'true', 0),
	(10, 1, E'D-0010', E'Súp bắp cua', E'http://product.hstatic.net/1000245833/product/mama12612_master.jpg', 50000, E'KHAI VỊ', 5, 4, NULL, E'ACTIVE', E'Súp bắp cua', E'Script', E'2019-11-22 10:36:41+07', E'Script', E'2019-11-22 10:36:43+07', E'true', 0),
	(5, 1, E'D-0005', E'Gỏi bắp cải', E'https://i.ytimg.com/vi/TltlU8GlBGo/maxresdefault.jpg', 80000, E'KHAI VỊ', 3, NULL, 2, E'ACTIVE', E'Gỏi bắp cải', E'Script', E'2019-11-22 10:31:15+07', E'Script', E'2019-11-22 10:31:16+07', E'true', 0),
	(6, 1, E'D-0006', E'Gỏi ngó sen', E'https://i.ytimg.com/vi/oP-T8cWnZss/hqdefault.jpg', 80000, E'KHAI VỊ', 3, 1, 3, E'ACTIVE', E'Gỏi ngó sen', E'Script', E'2019-11-22 10:31:54+07', E'Script', E'2019-11-22 10:31:56+07', E'true', 0),
	(3, 1, E'D-0003', E'Cơm chiên hải sản', E'https://anh.eva.vn/upload/4-2016/images/2016-11-11/1478858555-com-chien-hai-san_-watermark.jpg', 50000, E'MÓN CHÍNH', 4, 3, NULL, E'ACTIVE', E'Cơm chiên hải sản', E'Script', E'2019-11-22 10:29:21+07', E'Script', E'2019-11-22 10:29:24+07', E'true', 0),
	(4, 1, E'D-0004', E'Gỏi bắp bò', E'https://i.ytimg.com/vi/TltlU8GlBGo/maxresdefault.jpg', 80000, E'KHAI VỊ', 3, NULL, 1, E'ACTIVE', E'Gỏi bắp bò', E'Script', E'2019-11-22 10:30:09+07', E'Script', E'2019-11-22 10:30:25+07', E'true', 0),
	(2, 1, E'D-0002', E'Cơm chiên dương châu', E'https://cdn.netspace.edu.vn/news/2018/12/12/com-chien-duong-chau-5-1024-162720.jpg', 50000, E'MÓN CHÍNH', 4, 2, NULL, E'ACTIVE', E'Cơm chiên dương châu', E'Script', E'2019-11-22 10:28:11+07', E'Script', E'2019-11-22 10:28:13+07', E'true', 0),
	(13, 1, E'D-0013', E'Xôi khúc', E'https://noinauphodien.vn/wp-content/uploads/2018/10/Th%C3%A0nh-ph%E1%BA%A9m-c%E1%BB%A7a-c%C3%A1ch-l%C3%A0m-b%C3%A1nh-kh%C3%BAc.jpg', 50000, E'KHAI VỊ', 6, NULL, NULL, E'ACTIVE', E'Xôi khúc', E'Script', E'2019-11-22 10:39:08+07', E'Script', E'2019-10-22 10:39:10+07', E'true', 0),
	(15, 1, E'D-0015', E'xôi cuốn', E'http://www.dichvunauan.net/image.php?image=http://dichvunauan.net/uploads/news/b7d7511838f5341bf5e0c63e9dc1e27e.jpg&width=270px', 50000, E'KHAI VỊ', 6, NULL, NULL, E'ACTIVE', E'Xôi cuốn', E'Script', E'2020-02-06 18:17:37+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(21, 1, E'D-0021', E'Bò xào chua ngọt', E'http://www.dichvunauan.net/image.php?image=http://dichvunauan.net/uploads/news/3732e242d2c2a84ef8cfe5c585627b34.jpg&width=270px', 270000, E'MÓN CHÍNH', 1, NULL, NULL, E'ACTIVE', NULL, E'Script', E'2020-02-06 18:38:09+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(20, 1, E'D-0020', E'Gà nấu roti', E'https://nld.mediacdn.vn/zoom/640_426/2016/img-3023-1471921694945.jpg', 180000, E'MÓN CHÍNH', 2, NULL, NULL, E'ACTIVE', NULL, E'Script', E'2020-02-06 18:38:09+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(17, 1, E'D-0017', E'Gà hầm rau răm', E'http://www.dichvunauan.net/image.php?image=http://dichvunauan.net/uploads/news/a554296838aa9a56544d98b47ce23743.jpg&width=270px', 180000, E'MÓN CHÍNH', 2, NULL, NULL, E'ACTIVE', NULL, E'Script', E'2020-02-06 18:38:09+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(22, 1, E'D-0022', E'Bò nhúng giấm', E'http://www.dichvunauan.net/image.php?image=http://dichvunauan.net/uploads/news/c44324ba2c196494f3990cdf28fd486f.jpg&width=270px', 270000, E'MÓN CHÍNH', 1, NULL, NULL, E'ACTIVE', NULL, E'Script', E'2020-02-06 18:38:09+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(23, 1, E'D-0023', E'Bò nhúng mẻ', E'http://www.dichvunauan.net/image.php?image=http://dichvunauan.net/uploads/news/c44324ba2c196494f3990cdf28fd486f.jpg&width=270px', 300000, E'MÓN CHÍNH', 1, NULL, NULL, E'ACTIVE', NULL, E'Script', E'2020-02-06 18:38:09+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(24, 1, E'D-0024', E'Bò nấu nấm', E'https://massageishealthy.com/wp-content/uploads/2018/08/nhung-cac-mon-ngon-tu-thit-bo-xao-dai-tiec-don-gian.jpg', 320000, E'MÓN CHÍNh', 1, NULL, NULL, E'ACTIVE', NULL, E'Script', E'2020-02-06 18:38:09+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(25, 1, E'D-0025', E'Cơm chiên thập cập', E'https://lh3.googleusercontent.com/proxy/rfcMXeJN1zdtEPtumiS5HUxw1zpyjLOLCE0gHmwFhRNGaiHpqvyCnavCjF31U6qrW9TcbMYgzNcOc4_UYFYPRaSgFUd5kT_BBFKtEydqZ7hlDwvq8KveXIIaN0OaejeW4z9Emg3PftvJccoXluabMgVRNUc3ZqnXRwVA0_RXSDASAKD9FIEYcz7HMc2GherZ-bo', 50000, E'MÓN CHÍNH', 4, NULL, NULL, E'ACTIVE', NULL, E'Script', E'2020-02-06 18:38:09+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(27, 1, E'D-0027', E'Cơm trộn', E'https://daynauan.info.vn/wp-content/uploads/2015/05/com-tron-han-quoc.jpg', 120000, E'MÓN CHÍNH', 4, NULL, NULL, E'ACTIVE', NULL, E'Script', E'2020-02-06 18:38:09+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(26, 1, E'D-0026', E'Cơm xào bò', E'https://anh.eva.vn/upload/4-2016/images/2016-11-19/1479528543-com-chien-thit-bo.jpg', 50000, E'MÓN CHÍNH', 4, NULL, NULL, E'ACTIVE', NULL, E'Script', E'2020-02-06 18:38:09+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(16, 1, E'D-0016', E'Gà nướng ớt', E'http://www.dichvunauan.net/image.php?image=http://dichvunauan.net/uploads/news/604971e0cfc89d5c575ace78aa15e8db.jpg&width=270px', 180000, E'MÓN CHÍNH', 2, NULL, NULL, E'ACTIVE', E'Gà nướng', E'Script', E'2020-02-06 18:38:09+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(18, 1, E'D-0018', E'Gà hấp cải', E'http://www.dichvunauan.net/image.php?image=http://dichvunauan.net/uploads/news/88bd4386efd50a1ef028d9f4502a4341.jpg&width=270px', 180000, E'MÓN CHÍNH', 2, NULL, NULL, E'ACTIVE', NULL, E'Script', E'2020-02-06 18:38:09+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(19, 1, E'D-0019', E'Gà quay', E'http://www.dichvunauan.net/image.php?image=http://dichvunauan.net/uploads/news/85a1bc2b8294ab5794ac7ed662c1106e.jpg&width=270px', 180000, E'MÓN CHÍNH', 2, NULL, NULL, E'ACTIVE', NULL, E'Script', E'2020-02-06 18:38:09+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(14, 1, E'D-0014', E'Bánh bao sữa dừa trứng', E',http://www.dichvunauan.net/Banh-bao-sua-dua-trung.jpg', 180000, E'KHAI VỊ', 6, NULL, NULL, E'ACTIVE', NULL, E'Script', E'2020-02-06 18:38:09+07', E'Script', E'2020-01-06 18:38:52+07', E'true', 0),
	(28, 1, E'D-0028', E'Lẩu cá kèo', E'https://cdn.huongnghiepaau.com/wp-content/uploads/2018/06/640bc71f20c2ac282130971ea91627ee.jpg', 250000, E'MÓN LẨU', 7, NULL, NULL, E'ACTIVE', NULL, NULL, NULL, NULL, NULL, E'true', NULL),
	(29, 1, E'D-0029', E'Lẩu thái chua cay', E'https://lh3.googleusercontent.com/proxy/8btvvfd-jTzX-lJOo6xhspLHCXgqaCaIaL7SDFgRnRcQpfkRqcEkLBvC9pWuWHk5KX1n6bNd6Fu0-xwIlItYj5gDpr1J3ODJZlMej8YzZyyDd0pZFlXTkA', 250000, E'MÓN LẨU', 7, NULL, NULL, E'ACTIVE', NULL, NULL, NULL, NULL, NULL, E'true', NULL),
	(30, 1, E'D-0030', E'Lẩu nấm', E'https://anh.eva.vn//upload/4-2016/images/2016-11-19/lau-nam-cach-lam-lau-nam-9-1479520152-width500height375.jpg', 250000, E'MÓN LẨU', 7, NULL, NULL, E'ACTIVE', NULL, NULL, NULL, NULL, NULL, E'true', NULL),
	(31, 1, E'D-0031', E'Lẩu thập cẩm', E'https://nauzi.com/caches/large/cover/7246/tiet-lo-cach-nau-nuoc-lau-thap-cam-chuan-khong-can-chinh-3afce71e783d78dc10c4c177cf06ce0e.png', 300000, E'MÓN LẨU', 7, NULL, NULL, E'ACTIVE', NULL, NULL, NULL, NULL, NULL, E'true', NULL),
	(32, 1, E'D-0032', E'Lẩu cá đuối', E'https://www.cet.edu.vn/wp-content/uploads/2018/11/lau-ca-duoi.jpg', 320000, E'MÓN LẨU', 7, NULL, NULL, E'ACTIVE', NULL, NULL, NULL, NULL, NULL, E'true', NULL),
	(34, 1, E'D-0034', E'Yaourt phô mai', E'https://cdn.muabannhanh.com/asset/frontend/img/gallery/556734efd60a7_1432827119.png', 180000, E'TRÁNG MIỆNG', 8, NULL, NULL, E'ACTIVE', NULL, NULL, NULL, NULL, NULL, E'true', NULL),
	(33, 1, E'D-0033', E'Nho tươi Ninh Thuận', E'https://www.viettropfruit.com/wp-content/uploads/2016/09/nho-xanh-ninh-thuan-2.jpg', 250000, E'TRÁNG MIỆNG', 8, NULL, NULL, E'ACTIVE', NULL, NULL, NULL, NULL, NULL, E'true', NULL),
	(35, 1, E'D-0035', E'Bánh flan', E'http://www.dichvunauan.net/image.php?image=http://dichvunauan.net/uploads/news/520b623607d1fafda8a20b9ea3e1bd2f.jpg&width=270px', 250000, E'TRÁNG MIỆNG', 8, NULL, NULL, E'ACTIVE', NULL, NULL, NULL, NULL, NULL, E'true', NULL),
	(36, 1, E'D-0036', E'Quýt Thái', E'http://www.dichvunauan.net/image.php?image=http://dichvunauan.net/uploads/news/2f4e36c9141b7c1c2497b031bd7c9781.jpg&width=270px', 320000, E'TRÁNG MIỆNG', 8, NULL, NULL, E'ACTIVE', NULL, NULL, NULL, NULL, NULL, E'true', NULL),
	(37, 1, E'D-0037', E'Rau câu', E'http://www.dichvunauan.net/image.php?image=http://dichvunauan.net/uploads/news/a018a0f37bd10ad168f9537b3b06b611.jpg&width=270px', 270000, E'TRÁNG MIỆNG', 8, NULL, NULL, E'ACTIVE', NULL, NULL, NULL, NULL, NULL, E'true', NULL);

INSERT INTO "dish_item" ("dish_item_id", "dish_item_code", "dish_id", "item_id", "item_quantity", "uom_id", "dish_item_status", "dish_item_description", "created_by", "created_datetime", "updated_by", "updated_datetime", "active", "version") VALUES
	(1, E'D-0001-I', 4, 10, 0.8, 1, E'ACTIVE', E'0.8Kg bắp bò', E'Script', E'2019-11-22 11:09:24+07', E'Script', E'2019-11-22 11:09:27+07', E'true', 0),
	(4, E'D-0004-I', 1, 3, 0.3, 1, E'ACTIVE', E'0.3Kg thịt bò', E'Script', E'2019-11-22 11:12:45+07', E'Script', E'2019-11-22 11:12:47+07', E'true', 0),
	(5, E'D-0005-I', 1, 5, 3.0, 4, E'ACTIVE', E'3 Quả cà chua', E'Script', E'2019-11-22 11:13:46+07', E'Script', E'2019-11-22 11:13:47+07', E'true', 0),
	(2, E'D-0002-I', 4, 3, 1.0, 1, E'ACTIVE', E'1Kg thịt bò', E'Script', E'2019-11-22 11:10:01+07', E'Script', E'2019-11-22 11:10:03+07', E'true', 0),
	(3, E'D-0003-I', 4, 12, 3.0, 4, E'ACTIVE', E'3 Củ hành tím', E'Script', E'2019-11-22 11:10:43+07', E'Script', E'2019-11-22 11:10:47+07', E'true', 0),
	(6, E'D-0006-I', 2, 13, 0.4, 1, E'ACTIVE', E'0.4Kg gạo nếp', E'Script', E'2019-11-22 11:15:05+07', E'Script', E'2019-11-22 11:15:07+07', E'true', 0),
	(7, E'D-0007-I', 2, 2, 0.15, 1, E'ACTIVE', E'0.15Kg thịt heo', E'Script', E'2019-11-22 11:15:44+07', E'Script', E'2019-11-22 11:15:46+07', E'true', 0),
	(8, E'D-0008-I', 2, 3, 0.15, 1, E'ACTIVE', E'0.15Kg thịt bò', E'Script', E'2019-11-22 11:16:14+07', E'Script', E'2019-11-22 11:16:16+07', E'true', 0),
	(9, E'D-0009-I', 3, 13, 0.4, 1, E'ACTIVE', E'0.4Kg gạo nếp', E'Script', E'2019-11-22 11:17:12+07', E'Script', E'2019-11-22 11:17:13+07', E'true', 0),
	(10, E'D-0010-I', 3, 9, 0.3, 1, E'ACTIVE', E'0.3Kg tôm sú', E'Script', E'2019-11-22 11:17:54+07', E'Script', E'2019-11-22 11:17:56+07', E'true', 0);
