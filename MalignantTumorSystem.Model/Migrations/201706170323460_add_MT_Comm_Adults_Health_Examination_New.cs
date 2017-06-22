namespace MalignantTumorSystem.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_MT_Comm_Adults_Health_Examination_New : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MT_Comm_Adults_Health_Examination_New",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 50),
                        resident_id = c.String(maxLength: 50),
                        name = c.String(maxLength: 50),
                        sex = c.String(maxLength: 50),
                        age = c.String(maxLength: 50),
                        id_card_number = c.String(maxLength: 50),
                        birth_date = c.DateTime(),
                        community_code = c.String(maxLength: 50),
                        address = c.String(maxLength: 200),
                        phone = c.String(maxLength: 50),
                        zipcode = c.String(maxLength: 50),
                        worker_user_name = c.String(maxLength: 50),
                        worker_user_realname = c.String(maxLength: 50),
                        bianhao = c.String(maxLength: 50),
                        tijianriqi = c.DateTime(),
                        create_time = c.DateTime(),
                        zerenyisheng = c.String(maxLength: 50),
                        zhengzhuang = c.String(maxLength: 200),
                        ybzk_tiwen = c.String(maxLength: 50),
                        ybzk_mailv = c.String(maxLength: 50),
                        ybzk_huxipinglv = c.String(maxLength: 50),
                        ybzk_xueya_h = c.String(maxLength: 50),
                        ybzk_xueya_l = c.String(maxLength: 50),
                        ybzk_shenggao = c.String(maxLength: 50),
                        ybzk_tizhong = c.String(maxLength: 50),
                        ybzk_tizhizhishu = c.String(maxLength: 50),
                        ybzk_yaowei = c.String(maxLength: 50),
                        ybzk_tunwei = c.String(maxLength: 50),
                        ybzk_yaotunweibi = c.String(maxLength: 50),
                        ybzk_renzhi = c.String(maxLength: 50),
                        ybzk_renzhi_pingfen = c.String(maxLength: 50),
                        ybzk_qinggan = c.String(maxLength: 50),
                        ybzk_qinggan_pingfen = c.String(maxLength: 50),
                        shfs_duanlianpinglv = c.String(maxLength: 50),
                        shfs_duanlianshijian1 = c.String(maxLength: 50),
                        shfs_duanlianshijian2 = c.String(maxLength: 50),
                        shfs_duanlianfanshi = c.String(maxLength: 50),
                        shfs_yinshiqingkuan = c.String(maxLength: 50),
                        shfs_yinshiqingkuan2 = c.String(maxLength: 50),
                        shfs_xiyanzhuangkuan = c.String(maxLength: 50),
                        shfs_rixiyanliang = c.String(maxLength: 50),
                        shfs_kaishixiyannianling = c.String(maxLength: 50),
                        shfs_jieyannianling = c.String(maxLength: 50),
                        shfs_yinjiuqingkuan = c.String(maxLength: 50),
                        shfs_riyinjiuliang = c.String(maxLength: 50),
                        shfs_shifoujiejiu = c.String(maxLength: 50),
                        shfs_jiejiunianling = c.String(maxLength: 50),
                        shfs_kaishiyinjiunianling = c.String(maxLength: 50),
                        shfs_shifouzuijiu = c.String(maxLength: 50),
                        shfs_yinjiuzhonglei = c.String(maxLength: 50),
                        shfs_youwubaolu = c.String(maxLength: 50),
                        shfs_jutizhiye = c.String(maxLength: 50),
                        shfs_congyeshijian = c.String(maxLength: 50),
                        shfs_huaxueping = c.String(maxLength: 50),
                        shfs_duwu = c.String(maxLength: 50),
                        shfs_shexian = c.String(maxLength: 50),
                        shfs_fanhucuoshi_youwu1 = c.String(maxLength: 50),
                        shfs_fanhucuoshi1 = c.String(maxLength: 50),
                        shfs_fanhucuoshi_youwu2 = c.String(maxLength: 50),
                        shfs_fanhucuoshi2 = c.String(maxLength: 50),
                        shfs_fanhucuoshi_youwu3 = c.String(maxLength: 50),
                        shfs_fanhucuoshi3 = c.String(maxLength: 50),
                        zqgn_kouqun = c.String(maxLength: 50),
                        zqgn_chilie = c.String(maxLength: 50),
                        zqgn_quechi1 = c.String(maxLength: 50),
                        zqgn_quechi2 = c.String(maxLength: 50),
                        zqgn_quechi3 = c.String(maxLength: 50),
                        zqgn_quechi4 = c.String(maxLength: 50),
                        zqgn_quchi1 = c.String(maxLength: 50),
                        zqgn_quchi2 = c.String(maxLength: 50),
                        zqgn_quchi3 = c.String(maxLength: 50),
                        zqgn_quchi4 = c.String(maxLength: 50),
                        zqgn_yichi1 = c.String(maxLength: 50),
                        zqgn_yichi2 = c.String(maxLength: 50),
                        zqgn_yichi3 = c.String(maxLength: 50),
                        zqgn_yichi4 = c.String(maxLength: 50),
                        zqgn_yanbu = c.String(maxLength: 50),
                        zqgn_zuoyan = c.String(maxLength: 50),
                        zqgn_youyan = c.String(maxLength: 50),
                        zqgn_jiaozhengzuoyan = c.String(maxLength: 50),
                        zqgn_jiaozhengyouyan = c.String(maxLength: 50),
                        zqgn_tingli = c.String(maxLength: 50),
                        zqgn_yundonggongneng = c.String(maxLength: 50),
                        ct_pifu = c.String(maxLength: 50),
                        ct_pifu_qita = c.String(maxLength: 50),
                        ct_gongmo = c.String(maxLength: 50),
                        ct_gongmo_qita = c.String(maxLength: 50),
                        ct_linbajie = c.String(maxLength: 50),
                        ct_linbajie_qita = c.String(maxLength: 50),
                        ct_tongzhuangfei = c.String(maxLength: 50),
                        ct_huxiying = c.String(maxLength: 50),
                        ct_huxiying_yichang = c.String(maxLength: 50),
                        ct_luoying = c.String(maxLength: 50),
                        ct_luoying_gang = c.String(maxLength: 50),
                        ct_luoying_shi = c.String(maxLength: 50),
                        ct_xinlv = c.String(maxLength: 50),
                        ct_xinlve = c.String(maxLength: 50),
                        ct_zayin = c.String(maxLength: 50),
                        ct_zayin_you = c.String(maxLength: 50),
                        ct_yatong = c.String(maxLength: 50),
                        ct_yatong_you = c.String(maxLength: 50),
                        ct_baokuai = c.String(maxLength: 50),
                        ct_baokuai_you = c.String(maxLength: 50),
                        ct_gangda = c.String(maxLength: 50),
                        ct_gangda_you = c.String(maxLength: 50),
                        ct_gangda_you1 = c.String(maxLength: 50),
                        ct_gangda_you2 = c.String(maxLength: 50),
                        ct_pida = c.String(maxLength: 50),
                        ct_pida_you = c.String(maxLength: 50),
                        ct_pida_you1 = c.String(maxLength: 50),
                        ct_zhuyin = c.String(maxLength: 50),
                        ct_zhuyin_you = c.String(maxLength: 50),
                        ct_xiazhishuizhong = c.String(maxLength: 50),
                        ct_zubeidongmaibodong = c.String(maxLength: 50),
                        ct_gangmenzhizhen = c.String(maxLength: 50),
                        ct_gangmenzhizhen_qita = c.String(maxLength: 50),
                        ct_ruxian = c.String(maxLength: 50),
                        ct_waiyin = c.String(maxLength: 50),
                        ct_waiyin_qita = c.String(maxLength: 50),
                        ct_yindao = c.String(maxLength: 50),
                        ct_yindao_qita = c.String(maxLength: 50),
                        ct_gongjin = c.String(maxLength: 50),
                        ct_gongjin_qita = c.String(maxLength: 50),
                        ct_gongti = c.String(maxLength: 50),
                        ct_gongti_qita = c.String(maxLength: 50),
                        ct_fujian = c.String(maxLength: 50),
                        ct_fujian_qita = c.String(maxLength: 50),
                        ct_qita = c.String(maxLength: 500),
                        fzjc_kongfuxuetang1 = c.String(maxLength: 50),
                        fzjc_kongfuxuetang2 = c.String(maxLength: 50),
                        fzjc_xuehongdanbai = c.String(maxLength: 50),
                        fzjc_baixibao = c.String(maxLength: 50),
                        fzjc_xuexiaoban = c.String(maxLength: 50),
                        fzjc_xuechanggui_qita = c.String(maxLength: 500),
                        fzjc_niaodanbai = c.String(maxLength: 50),
                        fzjc_niaotang = c.String(maxLength: 50),
                        fzjc_niaodongti = c.String(maxLength: 50),
                        fzjc_niaoqianxue = c.String(maxLength: 50),
                        fzjc_niaochanggui_qita = c.String(maxLength: 500),
                        fzjc_niaoweiliangbaidanbai = c.String(maxLength: 50),
                        fzjc_dabianqianxue = c.String(maxLength: 50),
                        fzjc_bingZAM = c.String(maxLength: 50),
                        fzjc_guZAM = c.String(maxLength: 50),
                        fzjc_BDB = c.String(maxLength: 50),
                        fzjc_zongDHS = c.String(maxLength: 50),
                        fzjc_jieheDHS = c.String(maxLength: 50),
                        fzjc_xueqinjigan = c.String(maxLength: 50),
                        fzjc_xueniaosudan = c.String(maxLength: 50),
                        fzjc_xuejianongdu = c.String(maxLength: 50),
                        fzjc_xuenanongdu = c.String(maxLength: 50),
                        fzjc_zongdanguchun = c.String(maxLength: 50),
                        fzjc_jiataidanbai = c.String(maxLength: 50),
                        fzjc_gangyousanzhi = c.String(maxLength: 50),
                        fzjc_dimiduDGC = c.String(maxLength: 50),
                        fzjc_gaomiduDGC = c.String(maxLength: 50),
                        fzjc_tanghuaXHDB = c.String(maxLength: 50),
                        fzjc_biaomiankangyuan = c.String(maxLength: 50),
                        fzjc_yandi = c.String(maxLength: 50),
                        fzjc_yandi_yichang = c.String(maxLength: 50),
                        fzjc_xindiantu = c.String(maxLength: 50),
                        fzjc_xindiantu_yichang = c.String(maxLength: 50),
                        fzjc_X_pian = c.String(maxLength: 50),
                        fzjc_X_pian_yichang = c.String(maxLength: 50),
                        fzjc_B_chao = c.String(maxLength: 50),
                        fzjc_B_chao_qita = c.String(maxLength: 500),
                        fzjc_gongjintupian = c.String(maxLength: 50),
                        fzjc_gongjintupian_yichang = c.String(maxLength: 50),
                        fzjc_qita = c.String(maxLength: 500),
                        zytz_hepingzhi = c.String(maxLength: 50),
                        zytz_qixuzhi = c.String(maxLength: 50),
                        zytz_yangxuzhi = c.String(maxLength: 50),
                        zytz_yingxuzhi = c.String(maxLength: 50),
                        zytz_tangshizhi = c.String(maxLength: 50),
                        zytz_shirezhi = c.String(maxLength: 50),
                        zytz_xueyuzhi = c.String(maxLength: 50),
                        zytz_qiyuzhi = c.String(maxLength: 50),
                        zytz_tebingzhi = c.String(maxLength: 50),
                        jkwt_naoxueguanbing = c.String(maxLength: 50),
                        jkwt_shenzangjibing = c.String(maxLength: 50),
                        jkwt_xinzangjibing = c.String(maxLength: 50),
                        jkwt_xueguanjibing = c.String(maxLength: 50),
                        jkwt_yangbujibing = c.String(maxLength: 50),
                        jkwt_shengjingxitong = c.String(maxLength: 50),
                        jkwt_shengjingxitong_you = c.String(maxLength: 50),
                        jkwt_qitajibing = c.String(maxLength: 50),
                        jkwt_qitajibing_you = c.String(maxLength: 50),
                        jkpj_yichang = c.String(maxLength: 50),
                        jiankanzhidao = c.String(maxLength: 50),
                        weixianyinsu = c.String(maxLength: 50),
                        type = c.String(maxLength: 50),
                        perment_community_code = c.String(maxLength: 50),
                        permanent_home_address = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MT_Comm_Adults_Health_Examination_New");
        }
    }
}