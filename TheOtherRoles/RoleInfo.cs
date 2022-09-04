using System.Linq;
using System;
using System.Collections.Generic;
using TheOtherRoles.Players;
using static TheOtherRoles.TheOtherRoles;
using UnityEngine;

namespace TheOtherRoles
{
    class RoleInfo {
        public Color color;
        public string name;
        public string introDescription;
        public string shortDescription;
        public RoleId roleId;
        public bool isNeutral;
        public bool isModifier;

        RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId, bool isNeutral = false, bool isModifier = false) {
            this.color = color;
            this.name = name;
            this.introDescription = introDescription;
            this.shortDescription = shortDescription;
            this.roleId = roleId;
            this.isNeutral = isNeutral;
            this.isModifier = isModifier;
        }

        public static RoleInfo jester = new RoleInfo("小丑", Jester.color, "想盡一切辦法被丟出去", "想盡一切辦法被丟出去", RoleId.Jester, true);
        public static RoleInfo mayor = new RoleInfo("市長", Mayor.color, "你的票數被加倍了", "你的票數被加倍了", RoleId.Mayor);
        public static RoleInfo portalmaker = new RoleInfo("傳送者", Portalmaker.color, "建造傳送門", "建造傳送門", RoleId.Portalmaker);
        public static RoleInfo engineer = new RoleInfo("工程師",  Engineer.color, "盡快修理船上的破壞", "修理破壞", RoleId.Engineer);
        public static RoleInfo sheriff = new RoleInfo("警長", Sheriff.color, "執法<color=#FF1919FF>狼人</color>們", "執法狼人們", RoleId.Sheriff);
        public static RoleInfo deputy = new RoleInfo("警員", Sheriff.color, "給<color=#FF1919FF>狼人</color>們通通銬起來", "給狼人上銬", RoleId.Deputy);
        public static RoleInfo lighter = new RoleInfo("執燈人", Lighter.color, "你的燈光永不熄滅", "你的燈光永不熄滅", RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo("教父", Godfather.color, "殺光所有船員", "殺光所有船員", RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo("小弟", Mafioso.color, "幫助<color=#FF1919FF>黑手黨</color>殺死船員", "殺光所有船員", RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo("看門人", Janitor.color, "通過藏屍體的方式來幫助<color=#FF1919FF>黑手黨</color>", "藏光所有屍體", RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo("百變怪", Morphling.color, "通過改變你的樣貌來不被抓到", "改變你的樣貌", RoleId.Morphling);
        public static RoleInfo camouflager = new RoleInfo("魔術師", Camouflager.color, "隱蔽並殺死所有船員", "藏入人群中", RoleId.Camouflager);
        public static RoleInfo vampire = new RoleInfo("吸血鬼", Vampire.color, "用你那尖銳的牙齒殺死所有船員", "吸乾他人的血", RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo("抹除者", Eraser.color, "抹除其他人的職業並殺光所有船員", "抹除掉他人的職業", RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo("騙術師", Trickster.color, "使用你的驚嚇盒來嚇其他人", "給你的敵人一個驚喜", RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo("清潔工", Cleaner.color, "殺人不留痕跡", "殺人不留痕跡", RoleId.Cleaner);
        public static RoleInfo warlock = new RoleInfo("術士", Warlock.color, "詛咒並殺光所有人", "詛咒並殺光所有人", RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo("賞金獵人", BountyHunter.color, "拿下你的賞金目標", "拿下你的賞金目標", RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo("偵探", Detective.color, "用你觀察到的腳印來找出<color=#FF1919FF>狼人</color>們", "觀察腳印", RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo("時間大師", TimeMaster.color, "用你的時間之盾來保護你自己", "使用你的時間之盾", RoleId.TimeMaster);
        public static RoleInfo medic = new RoleInfo("醫生", Medic.color, "用你的護盾來保護其他人", "保護其他玩家", RoleId.Medic);
        public static RoleInfo shifter = new RoleInfo("交換者", Shifter.color, "改變你的職業", "改變你的職業", RoleId.Shifter);
        public static RoleInfo swapper = new RoleInfo("換票師", Swapper.color, "交換票數來逐出<color=#FF1919FF>狼人</color>們", "交換票數", RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo("先知", Seer.color, "你有一雙陰陽眼可以看到別人的死亡", "你可以看到別人的死亡", RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo("駭客", Hacker.color, "通過駭入系統來找到<color=#FF1919FF>狼人</color>們", "駭入系統來找出狼人", RoleId.Hacker);
        public static RoleInfo tracker = new RoleInfo("追蹤者", Tracker.color, "追蹤出<color=#FF1919FF>狼人</color>們的行跡", "追蹤出狼人", RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo("告密者", Snitch.color, "完成你的任務來找出<color=#FF1919FF>狼人</color>們", "完成你的任務", RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo("豺狼", Jackal.color, "殺光所有船員和<color=#FF1919FF>狼人</color>來獲得勝利", "殺光所有人", RoleId.Jackal, true);
        public static RoleInfo sidekick = new RoleInfo("跟班", Sidekick.color, "幫助豺狼殺光所有人", "幫助豺狼殺光所有人", RoleId.Sidekick, true);
        public static RoleInfo spy = new RoleInfo("間諜", Spy.color, "混入<color=#FF1919FF>狼</color>群中", "混入狼群中", RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo("警衛", SecurityGuard.color, "封鎖管道並放置監視器", "封鎖管道並放置監視器", RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo("縱火犯", Arsonist.color, "燃起來了(物理)", "燃起來了(物理)", RoleId.Arsonist, true);
        public static RoleInfo goodGuesser = new RoleInfo("正義的賭怪", Guesser.color, "生命即是豪賭", "生命即是豪賭", RoleId.NiceGuesser);
        public static RoleInfo badGuesser = new RoleInfo("邪惡的賭怪", Palette.ImpostorRed, "生命即是豪賭", "生命即是豪賭", RoleId.EvilGuesser);
        public static RoleInfo vulture = new RoleInfo("禿鷲", Vulture.color, "吃屍體來獲得勝利", "吃屍體來獲得勝利", RoleId.Vulture, true);
        public static RoleInfo medium = new RoleInfo("通靈師", Medium.color, "對靈魂問問題來獲得有利的資訊", "你為甚麼不去問問神奇靈魂呢", RoleId.Medium);
        public static RoleInfo lawyer = new RoleInfo("律師", Lawyer.color, "為你的客戶辯護", "為你的客戶辯護", RoleId.Lawyer, true);
        public static RoleInfo pursuer = new RoleInfo("起訴人", Pursuer.color, "給你的敵人塞上一個空包彈", "給你的敵人塞上一個空包彈", RoleId.Pursuer);
        public static RoleInfo impostor = new RoleInfo("偽裝者", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "破壞並殺死所有人"), "破壞並殺死所有人", RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo("船員", Color.white, "找出狼人和中立帶刀者", "找出狼人和中立帶刀者", RoleId.Crewmate);
        public static RoleInfo witch = new RoleInfo("女巫", Witch.color, "使用你的魔法來讓你的敵人死亡", "使用你的魔法來讓你的敵人死亡", RoleId.Witch);
        public static RoleInfo ninja = new RoleInfo("忍者", Ninja.color, "驚嚇並暗殺你的敵人", "驚嚇並暗殺你的敵人", RoleId.Ninja);



        // Modifier
        public static RoleInfo bloody = new RoleInfo("高血壓", Color.yellow, "你的殺手走路時會留下你的血跡", "你的殺手走路時會留下你的血跡", RoleId.Bloody, false, true);
        public static RoleInfo antiTeleport = new RoleInfo("通訊兵", Color.yellow, "遠端召開會議", "遠端張開會議", RoleId.AntiTeleport, false, true);
        public static RoleInfo tiebreaker = new RoleInfo("神之手", Color.yellow, "打破平票的規則", "打破平票的規則", RoleId.Tiebreaker, false, true);
        public static RoleInfo bait = new RoleInfo("誘餌", Color.yellow, "犧牲小我,完成大我", "犧牲小我,完成大我", RoleId.Bait, false, true);
        public static RoleInfo sunglasses = new RoleInfo("太陽眼鏡", Color.yellow, "你戴上了太陽眼鏡", "你的視野被縮小了", RoleId.Sunglasses, false, true);
        public static RoleInfo lover = new RoleInfo("戀人", Lovers.color, $"你墜入了愛河(物理)", $"你墜入了愛河(物理)", RoleId.Lover, false, true);
        public static RoleInfo mini = new RoleInfo("迷你船員", Color.yellow, "在你長大前沒有任何人可以傷害你", "沒有人能傷害你", RoleId.Mini, false, true);
        public static RoleInfo vip = new RoleInfo("VIP", Color.yellow, "你是VIP", "你死掉時全部人都會知道", RoleId.Vip, false, true);
        public static RoleInfo invert = new RoleInfo("醉漢", Color.yellow, "我反向操作啦awa", "暈死了我在走哪邊", RoleId.Invert, false, true);


        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            impostor,
            godfather,
            mafioso,
            janitor,
            morphling,
            camouflager,
            vampire,
            eraser,
            trickster,
            cleaner,
            warlock,
            bountyHunter,
            witch,
            ninja,
            goodGuesser,
            badGuesser,
            lover,
            jester,
            arsonist,
            jackal,
            sidekick,
            vulture,
            pursuer,
            lawyer,
            crewmate,
            shifter,
            mayor,
            portalmaker,
            engineer,
            sheriff,
            deputy,
            lighter,
            detective,
            timeMaster,
            medic,
            swapper,
            seer,
            hacker,
            tracker,
            snitch,
            spy,
            securityGuard,
            bait,
            medium,
            bloody,
            antiTeleport,
            tiebreaker,
            sunglasses,
            mini,
            vip,
            invert
        };

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p, bool showModifier = true) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Modifier
            if (showModifier) {
                // after dead modifier
                if (!CustomOptionHolder.modifiersAreHidden.getBool() || PlayerControl.LocalPlayer.Data.IsDead)
                {
                    if (Bait.bait.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bait);
                    if (Bloody.bloody.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bloody);
                    if (Vip.vip.Any(x => x.PlayerId == p.PlayerId)) infos.Add(vip);
                }
                if (p == Lovers.lover1 || p == Lovers.lover2) infos.Add(lover);
                if (p == Tiebreaker.tiebreaker) infos.Add(tiebreaker);
                if (AntiTeleport.antiTeleport.Any(x => x.PlayerId == p.PlayerId)) infos.Add(antiTeleport);
                if (Sunglasses.sunglasses.Any(x => x.PlayerId == p.PlayerId)) infos.Add(sunglasses);
                if (p == Mini.mini) infos.Add(mini);
                if (Invert.invert.Any(x => x.PlayerId == p.PlayerId)) infos.Add(invert);
            }

            // Special roles
            if (p == Jester.jester) infos.Add(jester);
            if (p == Mayor.mayor) infos.Add(mayor);
            if (p == Portalmaker.portalmaker) infos.Add(portalmaker);
            if (p == Engineer.engineer) infos.Add(engineer);
            if (p == Sheriff.sheriff || p == Sheriff.formerSheriff) infos.Add(sheriff);
            if (p == Deputy.deputy) infos.Add(deputy);
            if (p == Lighter.lighter) infos.Add(lighter);
            if (p == Godfather.godfather) infos.Add(godfather);
            if (p == Mafioso.mafioso) infos.Add(mafioso);
            if (p == Janitor.janitor) infos.Add(janitor);
            if (p == Morphling.morphling) infos.Add(morphling);
            if (p == Camouflager.camouflager) infos.Add(camouflager);
            if (p == Vampire.vampire) infos.Add(vampire);
            if (p == Eraser.eraser) infos.Add(eraser);
            if (p == Trickster.trickster) infos.Add(trickster);
            if (p == Cleaner.cleaner) infos.Add(cleaner);
            if (p == Warlock.warlock) infos.Add(warlock);
            if (p == Witch.witch) infos.Add(witch);
            if (p == Ninja.ninja) infos.Add(ninja);
            if (p == Detective.detective) infos.Add(detective);
            if (p == TimeMaster.timeMaster) infos.Add(timeMaster);
            if (p == Medic.medic) infos.Add(medic);
            if (p == Shifter.shifter) infos.Add(shifter);
            if (p == Swapper.swapper) infos.Add(swapper);
            if (p == Seer.seer) infos.Add(seer);
            if (p == Hacker.hacker) infos.Add(hacker);
            if (p == Tracker.tracker) infos.Add(tracker);
            if (p == Snitch.snitch) infos.Add(snitch);
            if (p == Jackal.jackal || (Jackal.formerJackals != null && Jackal.formerJackals.Any(x => x.PlayerId == p.PlayerId))) infos.Add(jackal);
            if (p == Sidekick.sidekick) infos.Add(sidekick);
            if (p == Spy.spy) infos.Add(spy);
            if (p == SecurityGuard.securityGuard) infos.Add(securityGuard);
            if (p == Arsonist.arsonist) infos.Add(arsonist);
            if (p == Guesser.niceGuesser) infos.Add(goodGuesser);
            if (p == Guesser.evilGuesser) infos.Add(badGuesser);
            if (p == BountyHunter.bountyHunter) infos.Add(bountyHunter);
            if (p == Vulture.vulture) infos.Add(vulture);
            if (p == Medium.medium) infos.Add(medium);
            if (p == Lawyer.lawyer) infos.Add(lawyer);
            if (p == Pursuer.pursuer) infos.Add(pursuer);

            // Default roles
            if (infos.Count == 0 && p.Data.Role.IsImpostor) infos.Add(impostor); // Just Impostor
            if (infos.Count == 0 && !p.Data.Role.IsImpostor) infos.Add(crewmate); // Just Crewmate

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors, bool showModifier = true) {
            string roleName;
            roleName = String.Join(" ", getRoleInfoForPlayer(p, showModifier).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (Lawyer.target != null && p.PlayerId == Lawyer.target.PlayerId && CachedPlayer.LocalPlayer.PlayerControl != Lawyer.target) roleName += (useColors ? Helpers.cs(Pursuer.color, " §") : " §");
            return roleName;
        }
    }
}
