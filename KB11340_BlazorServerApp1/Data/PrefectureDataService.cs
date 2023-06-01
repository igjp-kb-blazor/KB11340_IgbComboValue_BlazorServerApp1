namespace KB11340_BlazorServerApp1.Data;

public class PrefectureDataService
{
    private Prefecture[] _prefectures;
    public PrefectureDataService()
    {
        this._prefectures = new Prefecture[]
        {
            new () { PrefectureCode = "01", PrefectureName = "北海道" },
            new () { PrefectureCode = "02", PrefectureName = "青森県" },
            new () { PrefectureCode = "03", PrefectureName = "岩手県" },
            new () { PrefectureCode = "04", PrefectureName = "宮城県" },
            new () { PrefectureCode = "05", PrefectureName = "秋田県" },
            new () { PrefectureCode = "06", PrefectureName = "山形県" },
            new () { PrefectureCode = "07", PrefectureName = "福島県" },
            new () { PrefectureCode = "08", PrefectureName = "茨城県" },
            new () { PrefectureCode = "09", PrefectureName = "栃木県" },
            new () { PrefectureCode = "10", PrefectureName = "群馬県" },
            new () { PrefectureCode = "11", PrefectureName = "埼玉県" },
            new () { PrefectureCode = "12", PrefectureName = "千葉県" },
            new () { PrefectureCode = "13", PrefectureName = "東京都" },
            new () { PrefectureCode = "14", PrefectureName = "神奈川県" },
            new () { PrefectureCode = "15", PrefectureName = "新潟県" },
            new () { PrefectureCode = "16", PrefectureName = "富山県" },
            new () { PrefectureCode = "17", PrefectureName = "石川県" },
            new () { PrefectureCode = "18", PrefectureName = "福井県" },
            new () { PrefectureCode = "19", PrefectureName = "山梨県" },
            new () { PrefectureCode = "20", PrefectureName = "長野県" },
            new () { PrefectureCode = "21", PrefectureName = "岐阜県" },
            new () { PrefectureCode = "22", PrefectureName = "静岡県" },
            new () { PrefectureCode = "23", PrefectureName = "愛知県" },
            new () { PrefectureCode = "24", PrefectureName = "三重県" },
            new () { PrefectureCode = "25", PrefectureName = "滋賀県" },
            new () { PrefectureCode = "26", PrefectureName = "京都府" },
            new () { PrefectureCode = "27", PrefectureName = "大阪府" },
            new () { PrefectureCode = "28", PrefectureName = "兵庫県" },
            new () { PrefectureCode = "29", PrefectureName = "奈良県" },
            new () { PrefectureCode = "30", PrefectureName = "和歌山県" },
            new () { PrefectureCode = "31", PrefectureName = "鳥取県" },
            new () { PrefectureCode = "32", PrefectureName = "島根県" },
            new () { PrefectureCode = "33", PrefectureName = "岡山県" },
            new () { PrefectureCode = "34", PrefectureName = "広島県" },
            new () { PrefectureCode = "35", PrefectureName = "山口県" },
            new () { PrefectureCode = "36", PrefectureName = "徳島県" },
            new () { PrefectureCode = "37", PrefectureName = "香川県" },
            new () { PrefectureCode = "38", PrefectureName = "愛媛県" },
            new () { PrefectureCode = "39", PrefectureName = "高知県" },
            new () { PrefectureCode = "40", PrefectureName = "福岡県" },
            new () { PrefectureCode = "41", PrefectureName = "佐賀県" },
            new () { PrefectureCode = "42", PrefectureName = "長崎県" },
            new () { PrefectureCode = "43", PrefectureName = "熊本県" },
            new () { PrefectureCode = "44", PrefectureName = "大分県" },
            new () { PrefectureCode = "45", PrefectureName = "宮崎県" },
            new () { PrefectureCode = "46", PrefectureName = "鹿児島県" },
            new () { PrefectureCode = "47", PrefectureName = "沖縄県" },
        };
    }

    public Task<Prefecture[]> GetPrefectures()
    {
        return Task.FromResult(this._prefectures);
    }
}
