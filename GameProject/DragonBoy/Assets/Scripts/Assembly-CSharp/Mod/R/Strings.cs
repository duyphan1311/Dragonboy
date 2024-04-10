﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod.R
{
    internal static class Strings
    {
        internal static readonly string DEFAULT_IP_SERVERS = "Vũ trụ 1:dragon1.teamobi.com:14445:0:0:0,Vũ trụ 2:dragon2.teamobi.com:14445:0:0:0,Vũ trụ 3:dragon3.teamobi.com:14445:0:0:0,Vũ trụ 4:dragon4.teamobi.com:14445:0:0:0,Vũ trụ 5:dragon5.teamobi.com:14445:0:0:0,Vũ trụ 6:dragon6.teamobi.com:14445:0:0:0,Vũ trụ 7:dragon7.teamobi.com:14445:0:0:0,Vũ trụ 8:dragon10.teamobi.com:14446:0:0:0,Vũ trụ 9:dragon10.teamobi.com:14447:0:0:0,Vũ trụ 10:dragon10.teamobi.com:14445:0:0:0,Vũ trụ 11:dragon11.teamobi.com:14445:0:0:0,Vũ trụ 12:dragon12.teamobi.com:14445:0:0:1,Võ đài liên vũ trụ:dragonwar.teamobi.com:20000:0:0:0,Universe 1:dragon.indonaga.com:14445:1:0:0,Naga:dragon.indonaga.com:14446:2:0:0,Super 1:dragon11.teamobi.com:14446:0:1:1,0,0";
        #region Fields
        internal static string communityMod = "";
        internal static string gameVersion = "";
        internal static string registered = "";
        internal static string arbitration = "";
        internal static string autoChatDisabled = "";
        internal static string inputContent = "";
        internal static string delaySeconds = "";
        internal static string viewContent = "";
        internal static string autoChatContent = "";
        internal static string inputDelay = "";
        internal static string timeMilliseconds = "";
        internal static string errorOccurred = "";
        internal static string contentSaved = "";
        internal static string delayChanged = "";
        internal static string autoAttack = "";
        internal static string gobackTo = "";
        internal static string youAreNotNamekian = "";
        internal static string completed = "";
        internal static string[][] modMenuPanelTabName = new string[0][];
        internal static string someonePet = "";
        internal static string petLostMaster = "";
        internal static string zone = "";
        internal static string vSyncDescription = "";
        internal static string showTargetInfoTitle = "";
        internal static string showTargetInfoDescription = "";
        internal static string autoSendAttackDescription = "";
        internal static string showCharListTitle = "";
        internal static string showCharListDescription = "";
        internal static string showPetInCharListTitle = "";
        internal static string showPetInCharListDescription = "";
        internal static string autoTrainForNewbieTitle = "";
        internal static string autoTrainForNewbieDescription = "";
        internal static string noLongerNewAccount = "";
        internal static string customBackgroundTitle = "";
        internal static string customBackgroundDescription = "";
        internal static string notifyBossTitle = "";
        internal static string notifyBossDescription = "";
        internal static string pickMobTitle = "";
        internal static string pickMobDescription = "";
        internal static string functionShouldBeDisabled = "";
        internal static string functionShouldBeEnabled = "";
        internal static string avoidSuperMobTitle = "";
        internal static string avoidSuperMobDescription = "";
        internal static string vdhTitle = "";
        internal static string vdhDescription = "";
        internal static string autoPickItemTitle = "";
        internal static string autoPickItemDescription = "";
        internal static string pickMyItemOnlyTitle = "";
        internal static string pickMyItemOnlyDescription = "";
        internal static string limitPickTimesTitle = "";
        internal static string limitPickTimesDescription = "";
        internal static string autoAskForPeansTitle = "";
        internal static string autoAskForPeansDescription = "";
        internal static string youAreNotInAClan = "";
        internal static string autoDonatePeansTitle = "";
        internal static string autoDonatePeansDescription = "";
        internal static string autoHarvestPeansTitle = "";
        internal static string autoHarvestPeansDescription = "";
        internal static string setFPSDescription = "";
        internal static string setReduceGraphicsTitle = "";
        internal static string level = "";
        internal static string[] setReduceGraphicsChoices = new string[0];
        internal static string[] setGoBackChoices = new string[0];
        internal static string setAutoTrainPetTitle = "";
        internal static string[] setAutoTrainPetChoices = new string[0];
        internal static string youDontHaveDisciple = "";
        internal static string setAutoAttackWhenDiscipleNeededTitle = "";
        internal static string[] setAutoAttackWhenDiscipleNeededChoices = new string[0];
        internal static string setAutoRescueTitle = "";
        internal static string[] setAutoRescueChoices = new string[0];
        internal static string setTimeChangeCustomBgTitle = "";
        internal static string setTimeChangeCustomBgDescription = "";
        internal static string openXmapMenuTitle = "";
        internal static string openXmapMenuDescription = "";
        internal static string openPickMobMenuTitle = "";
        internal static string openPickMobMenuDescription = "";
        internal static string openTeleportMenuTitle = "";
        internal static string openTeleportMenuDescription = "";
        internal static string openCustomBackgroundMenuTitle = "";
        internal static string openCustomBackgroundMenuDescription = "";
        internal static string openSetsMenuTitle = "";
        internal static string openSetsMenuDescription = "";
        #endregion

        internal static void LoadLanguage(sbyte newLanguage)
        {
            switch (newLanguage)
            {
                case 0:
                    LoadLanguageVI();
                    break;
                case 1:
                    LoadLanguageEN();
                    break;
                case 2:
                    LoadLanguageID();
                    break;
            }
        }

        internal static string OnOffStatus(bool value) => value ? mResources.ON : mResources.OFF;

        static void LoadLanguageVI()
        {
            communityMod = "NRO Mod Cộng đồng";
            gameVersion = "Phiên bản game";
            registered = "Đã đăng ký";
            arbitration = "Trọng tài";
            autoChatDisabled = "Đã tắt Auto Chat";
            inputContent = "Nhập nội dung";
            delaySeconds = "Delay:\n{0} giây";
            viewContent = "Xem nội dung";
            autoChatContent = "Nội dung Auto Chat";
            inputDelay = "Nhập thời gian delay";
            timeMilliseconds = "Thời gian (ms)";
            errorOccurred = "Có lỗi xảy ra";
            contentSaved = "Đã lưu nội dung";
            delayChanged = "Đã đổi delay thành {0} giây";
            autoAttack = "Tự đánh";
            gobackTo = "Goback đến map: {0}, khu: {1}, tọa độ: ({2}, {3})";
            youAreNotNamekian = "Bạn không phải là Namek";
            completed = "Đã hoàn thành";
            modMenuPanelTabName = new string[][]
            {
                new string[]{ "Bật/tắt", "" },
                new string[]{ "Điều", "chỉnh" },
                new string[]{ "Chức", "năng" },
            };
            someonePet = $" [<color=cyan>{mResources.pet}</color> của {{0}}]";
            petLostMaster = $" [<color=cyan>{mResources.pet}</color> bị lạc sư phụ]";
            zone = "khu";
            functionShouldBeDisabled = "Bạn cần tắt chức năng \"{0}\"!";
            functionShouldBeEnabled = "Bạn cần bật chức năng \"{0}\"!";

            vSyncDescription = "Tự động giới hạn FPS theo tốc độ khung hình của màn hình";
            showTargetInfoTitle = "Thông tin đối thủ";
            showTargetInfoDescription = "Hiện gần chính xác thời gian NRD, khiên, khỉ, huýt sáo... của đối thủ";
            autoSendAttackDescription = "Tự động gửi lệnh tấn công mục tiêu mà không di chuyển nhân vật";
            showCharListTitle = "Danh sách nhân vật";
            showCharListDescription = "Hiện danh sách nhân vật trong khu hiện tại";
            showPetInCharListTitle = "Hiện đệ tử trong danh sách nhân vật";
            showPetInCharListDescription = "Hiện đệ tử trong danh sách nhân vật trong khu hiện tại";
            autoTrainForNewbieTitle = "Tự động up SS";
            autoTrainForNewbieDescription = "Tự động up acc mới đến nhiệm vụ vào bang";
            noLongerNewAccount = "Bạn đã qua nhiệm vụ vào bang";
            customBackgroundTitle = "Hình nền tùy chỉnh";
            customBackgroundDescription = "Thay thế hình nền mặc định của game bằng hình nền tùy chỉnh";
            notifyBossTitle = "Thông báo Boss";
            notifyBossDescription = "Hiển thị danh sách thông báo boss";
            pickMobTitle = "Tàn sát";
            pickMobDescription = "Tự động đánh quái";

            avoidSuperMobTitle = "Né siêu quái khi tàn sát";
            avoidSuperMobDescription = "Không đánh siêu quái khi tàn sát";
            vdhTitle = "Vượt địa hình khi tàn sát";
            vdhDescription = "Tự động vượt địa hình khi đang tàn sát";
            autoPickItemTitle = "Tự động nhặt vật phẩm";
            autoPickItemDescription = "Tự động nhặt vật phẩm ở gần";
            pickMyItemOnlyTitle = "Không nhặt vật phẩm của người khác";
            pickMyItemOnlyDescription = "Chỉ nhặt vật phẩm của bản thân, do đệ tử đánh quái rơi ra và vật phẩm không thuộc về bất cứ ai";
            limitPickTimesTitle = "Giới hạn số lần nhặt";
            limitPickTimesDescription = "Giới hạn số lần tự động nhặt một vật phẩm";
            autoAskForPeansTitle = "Auto xin đậu";
            autoAskForPeansDescription = "Tự động gửi tin nhắn xin đậu thần vào kênh chat bang hội";
            youAreNotInAClan = "Bạn không ở trong bang hội nào";
            autoDonatePeansTitle = "Auto cho đậu";
            autoDonatePeansDescription = "Tự động cho đậu thần khi có tin nhắn xin đậu thần của các thành viên trong bang hội";
            autoHarvestPeansTitle = "Auto vặt đậu";
            autoHarvestPeansDescription = "Tự động thu hoạch đậu thần từ cây đậu thần ở nhà";
            setFPSDescription = "Điều chỉnh số lượng khung hình trên giây của game";
            setReduceGraphicsTitle = "Giảm đồ họa";
            level = "Mức";
            setReduceGraphicsChoices = new string[]
            {
                "Đang tắt",
                $"Đang bật ({level.ToLower()} 1)",
                $"Đang bật ({level.ToLower()} 2)",
                $"Đang bật ({level.ToLower()} 3)",
            };
            setGoBackChoices = new string[]
            {
                "Đang tắt",
                "Đang bật (quay lại chỗ cũ khi chết)",
                "Đang bật (đến map, khu và tọa độ cố định khi chết)",
            };
            setAutoTrainPetTitle = "Auto up đệ tử";
            setAutoTrainPetChoices = new string[] 
            {
                "Đang tắt",
                "Đang bật (up đệ thường)", 
                "Đang bật (up đệ né siêu quái)",
                "Đang bật (up đệ Kaioken)" 
            };
            youDontHaveDisciple = "Bạn không có đệ tử";
            setAutoAttackWhenDiscipleNeededTitle = "Đánh khi đệ kêu";
            setAutoAttackWhenDiscipleNeededChoices = new string[] 
            {
                "Đánh quái gần nhất",
                "Đánh đệ tử (tự động bật cờ xám)",
                "Đánh bản thân (tự động bật cờ xám)" 
            };
            setAutoRescueTitle = "Auto trị thương";
            setAutoRescueChoices = new string[]
            { 
                "Đang tắt",
                "Đang bật (trị thương mọi người)",
                "Đang bật (chỉ thành viên trong bang hội)",
                "Đang bật (chỉ đệ tử)",
                "Đang bật (chỉ đệ tử của bản thân)"
            };
            setTimeChangeCustomBgTitle = "Thời gian đổi hình nền";
            setTimeChangeCustomBgDescription = "Điều chỉnh thời gian thay đổi hình nền (giây)";
            openXmapMenuTitle = "Menu Xmap";
            openXmapMenuDescription = "Mở menu Xmap (lệnh \"xmp\" hoặc nút \'x\')";
            openPickMobMenuTitle = "Menu PickMob";
            openPickMobMenuDescription = "Mở menu PickMob (lệnh \"pickmob\")";
            openTeleportMenuTitle = "Menu Teleport";
            openTeleportMenuDescription = "Mở menu dịch chuyển (lệnh \"tele\" hoặc nút \'z\')";
            openCustomBackgroundMenuTitle = "Menu Custom Background";
            openCustomBackgroundMenuDescription = "Mở menu hình nền tùy chỉnh";
            openSetsMenuTitle = "Menu Set đồ";
            openSetsMenuDescription = "Mở menu set đồ (lệnh \"set\" hoặc nút \'`\')";
        }

        static void LoadLanguageEN()
        {
            communityMod = "DBO Community Mod";
            gameVersion = "Game version";
            registered = "Registered";
            arbitration = "Arbitration";
            autoChatDisabled = "Auto Chat disabled";
            inputContent = "Input content";
            delaySeconds = "Delay:\n{0} seconds";
            viewContent = "View content";
            autoChatContent = "Auto Chat contents";
            inputDelay = "Input delay time";
            timeMilliseconds = "Time (ms)";
            errorOccurred = "Error occurred";
            contentSaved = "Content saved";
            delayChanged = "Changed delay to {0} seconds";
            autoAttack = "Auto attack";
            gobackTo = "Goback to map: {0}, zone: {1}, coordinates: ({2}, {3})";
            youAreNotNamekian = "You are not a Namekian character";
            completed = "Completed";
            modMenuPanelTabName = new string[][]
            {
                new string[]{ "Toggle", "" },
                new string[]{ "Adjust", "" },
                new string[]{ "Func-", "tions" },
            };
            someonePet = $" [{{0}}'s <color=cyan>{mResources.pet}</color>]";
            petLostMaster = $" [<color=cyan>{mResources.pet}</color> lost master]";
            zone = "zone";
            functionShouldBeDisabled = "You need to disable the \"{0}\" feature!";
            functionShouldBeEnabled = "You need to enable the \"{0}\" feature!";

            vSyncDescription = "Automatically limit the FPS according to the monitor's refresh rate";
            showTargetInfoTitle = "Target's effect information";
            showTargetInfoDescription = "Show the near-accurate duration of Black Star Dragonball, Energy Shield, Super Monkey, Whistle, etc. of the target character";
            autoSendAttackDescription = "Automatically send attack commands to the target character without moving your character";
            showCharListTitle = "Character list";
            showCharListDescription = "Show the character list in the current zone";
            showPetInCharListTitle = "Include disciples in the character list";
            showPetInCharListDescription = "Include disciples in the character list in the current zone";
            autoTrainForNewbieTitle = "Auto train new account";
            autoTrainForNewbieDescription = "Auto train new account until the clan mission";
            noLongerNewAccount = "You have completed the clan mission";
            customBackgroundTitle = "Custom background wallpaper";
            customBackgroundDescription = "Replace the game default background with custom wallpaper";
            notifyBossTitle = "Boss notification";
            notifyBossDescription = "Show boss notification list";
            pickMobTitle = "Slaughter";
            pickMobDescription = "Auto attack monsters";
            avoidSuperMobTitle = "Avoid super monsters";
            avoidSuperMobDescription = "Don't attack super monsters when slaughtering";
            vdhTitle = "Cross terrain while slaughtering";
            vdhDescription = "Automatically cross terrain while slaughtering";
            autoPickItemTitle = "Auto pick items";
            autoPickItemDescription = "Automatically pick up nearby items";
            pickMyItemOnlyTitle = "Don't pick up other people's items";
            pickMyItemOnlyDescription = "Only pick up your own items, items dropped by your own disciples when fighting monsters, and items that do not belong to anyone";
            limitPickTimesTitle = "Limit the number of pickup attempts";
            limitPickTimesDescription = "Limit the number of attempts to pick up an item";
            autoAskForPeansTitle = "Auto ask for Senzu beans";
            autoAskForPeansDescription = "Automatically send messages asking for Senzu beans to the clan chat channel";
            youAreNotInAClan = "You are not in any clan";
            autoDonatePeansTitle = "Auto donate Senzu beans";
            autoDonatePeansDescription = "Automatically give Senzu beans when there is a request message from a clan member";
            autoHarvestPeansTitle = "Auto harvest Senzu beans";
            autoHarvestPeansDescription = "Automatically harvest Senzu beans from the Senzu tree at home";
            setFPSDescription = "Adjust the number of frames per second of the game";
            setReduceGraphicsTitle = "Reduce graphics quality";
            level = "Level";
            setReduceGraphicsChoices = new string[]
            {
                "Disabled",
                $"Enabled ({level.ToLower()} 1)",
                $"Enabled ({level.ToLower()} 2)",
                $"Enabled ({level.ToLower()} 3)",
            };
            setGoBackChoices = new string[]
            {
                "Disabled",
                "Enabled (return to the same place where you died)",
                "Enabled (go to the fixed map, zone, and position when you died)",
            };
            setAutoTrainPetTitle = "Auto train disciple";
            setAutoTrainPetChoices = new string[]
            {
                "Disabled",
                "Enabled (normal mode)",
                "Enabled (avoid super monsters mode)",
                "Enabled (kaioken mode)"
            };
            youDontHaveDisciple = "You don't have disciple";
            setAutoAttackWhenDiscipleNeededTitle = "Attack when the disciple needs";
            setAutoAttackWhenDiscipleNeededChoices = new string[]
            {
                "Nearest monster",
                "Attack the disciple (automatically change flag to gray)",
                "Attack self (automatically change flag to gray)"
            };
            setAutoRescueTitle = "Auto rescue";
            setAutoRescueChoices = new string[]
            {
                "Disabled",
                "Enabled (everyone)",
                "Enabled (clan members only)",
                "Enabled (disciple only)",
                "Enabled (own disciple only)"
            };
            setTimeChangeCustomBgTitle = "Background duration";
            setTimeChangeCustomBgDescription = "Adjust the time to switch background wallpaper (seconds)";
            openXmapMenuTitle = "Xmap menu";
            openXmapMenuDescription = "Open the Xmap menu (\"xmp\" chat command or \'x\' key)";
            openPickMobMenuTitle = "PickMob menu";
            openPickMobMenuDescription = "Open the PickMob menu (\"pickmob\" chat command)";
            openTeleportMenuTitle = "Teleport menu";
            openTeleportMenuDescription = "Open the Teleport menu (\"tele\" chat command or \'z\' key)";
            openCustomBackgroundMenuTitle = "Custom Background menu";
            openCustomBackgroundMenuDescription = "Open the Custom Background menu";
            openSetsMenuTitle = "Sets menu";
            openSetsMenuDescription = "Open the Sets menu (\"set\" command or \'`\' key)";
        }

        static void LoadLanguageID()
        {
            communityMod = "Mod Komunitas DBO";
            gameVersion = "Versi game";
            registered = "Terdaftar";
            arbitration = "Penyelenggara";
            autoChatDisabled = "Auto Chat dinonaktifkan";
            inputContent = "Masukkan konten";
            delaySeconds = "Penundaan:\n{0} detik";
            viewContent = "Lihat konten";
            autoChatContent = "Konten Auto Chat";
            inputDelay = "Masukkan waktu penundaan";
            timeMilliseconds = "Waktu (ms)";
            errorOccurred = "Terjadi kesalahan";
            contentSaved = "Konten disimpan";
            delayChanged = "Mengubah penundaan menjadi {0} detik";
            autoAttack = "Serangan otomatis";
            gobackTo = "Kembali ke peta: {0}, zona: {1}, koordinat: ({2}, {3})";
            youAreNotNamekian = "Anda bukan karakter Namekian";
            completed = "Selesai";
            modMenuPanelTabName = new string[][]
            {
                new string[]{ "Beralih", "" },
                new string[]{ "Menyes-", "uaikan" },
                new string[]{ "fungsi", "" },
            };
            someonePet = $" [<color=cyan>{mResources.pet}</color> {{0}}]";
            petLostMaster = $" [<color=cyan>{mResources.pet}</color> itu kehilangan gurunya]";
            zone = "zona";
            functionShouldBeDisabled = "Anda perlu menonaktifkan fitur \"{0}\"!";
            functionShouldBeEnabled = "Anda harus mengaktifkan fitur \"{0}\"!";

            vSyncDescription = "Secara otomatis membatasi FPS sesuai dengan kecepatan refresh layar";
            showTargetInfoTitle = "Informasi sasaran";
            showTargetInfoDescription = "Menampilkan waktu bola naga bintang hitam, perisai energi, transformasi, peluit... hampir seakurat mungkin untuk karakter sasaran";
            autoSendAttackDescription = "Secara otomatis mengirim perintah serangan ke sasaran tanpa memindahkan karakter";
            showCharListTitle = "Daftar karakter";
            showCharListDescription = "Menampilkan daftar karakter di zona saat ini";
            showPetInCharListTitle = "Sertakan murid dalam daftar karakter";
            showPetInCharListDescription = "Sertakan murid dalam daftar karakter di zona saat ini";
            autoTrainForNewbieTitle = "Latih akun baru secara otomatis";
            autoTrainForNewbieDescription = "Latih otomatis akun baru ke misi klan";
            noLongerNewAccount = "Anda telah melewati misi klan";
            customBackgroundTitle = "Wallpaper khusus";
            customBackgroundDescription = "Ganti latar belakang game dengan wallpaper khusus";
            notifyBossTitle = "Pemberitahuan Boss";
            //someone pls translate this
            notifyBossDescription = "";
        }
    }
}
