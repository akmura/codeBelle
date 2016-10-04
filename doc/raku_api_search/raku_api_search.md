# 楽天トラベルAPIの仕様調査

## 概要
* API名：[楽天トラベルキーワード検索API](https://webservice.rakuten.co.jp/api/keywordhotelsearch/)
* 検索内容：任意のキーワード（観光地名など）だけを指定して検索する（とりあえず）  

## リクエストURL
* URL  
https://app.rakuten.co.jp/services/api/Travel/KeywordHotelSearch/20131024?format=json&keyword=%[検索キーワード]&applicationId=[アプリケーションID]

* 例（「高尾山」で検索）  
https://app.rakuten.co.jp/services/api/Travel/KeywordHotelSearch/20131024?format=json&keyword=%E9%AB%98%E5%B0%BE%E5%B1%B1&applicationId=99999999999999


## 結果
* 内容（抜粋）
__※形式：json__  


```json:
{
  "pagingInfo": {
    "recordCount": 31,
    "pageCount": 2,
    "page": 1,
    "first": 1,
    "last": 30
  },
  "hotels": [
    {
      "hotel": [
        {
          "hotelBasicInfo": {
            "hotelNo": 109105,
            "hotelName": "ホテルウィングインターナショナル新宿",
            "hotelInformationUrl": "http://img.travel.rakuten.co.jp/image/tr/api/kw/JBe8h/?f_no=109105",
            "planListUrl": "http://img.travel.rakuten.co.jp/image/tr/api/kw/3VTwt/?f_no=109105&f_flg=PLAN",
            "dpPlanListUrl": "http://img.travel.rakuten.co.jp/image/tr/api/kw/IWrzP/?noTomariHotel=109105",
            "reviewUrl": "http://img.travel.rakuten.co.jp/image/tr/api/kw/HTX0u/?f_hotel_no=109105",
            "hotelKanaName": "うぃんぐいんたーなしょなるしんじゅく",
            "hotelSpecial": "ＪＲ新宿駅東口より徒歩６分。西武新宿駅中央口より徒歩１分。",
            "hotelMinCharge": 4150,
            "latitude": 128491.51,
            "longitude": 502935.39,
            "postalCode": "160-0021",
            "address1": "東京都",
            "address2": "新宿区歌舞伎町1-21-7",
            "telephoneNo": "03-3200-0122",
            "faxNo": "03-3200-8086",
            "access": "ＪＲ　新宿駅東口より徒歩６分／西武新宿駅より徒歩１分",
            "parkingInformation": "無し",
            "nearestStation": "西武新宿",
            "hotelImageUrl": "http://img.travel.rakuten.co.jp/share/HOTEL/109105/109105.jpg",
            "hotelThumbnailUrl": "http://img.travel.rakuten.co.jp/HIMG/90/109105.jpg",
            "roomImageUrl": "http://img.travel.rakuten.co.jp/share/HOTEL/109105/109105_tw.jpg",
            "roomThumbnailUrl": "http://img.travel.rakuten.co.jp/HIMG/INTERIOR/109105.jpg",
            "hotelMapImageUrl": "http://img.travel.rakuten.co.jp/share/HOTEL/109105/109105map.gif",
            "reviewCount": 461,
            "reviewAverage": 4.21,
            "userReview": "無料ドリンクや自動販売機の値段設定などとても良かったです。ただ、残念だったのはバスタブの排水漏れでした。　2016-09-22 18:21:43投稿"
          }
        },
        {
          "hotelRatingInfo": {
            "serviceAverage": 3.96,
            "locationAverage": 4.59,
            "roomAverage": 4.21,
            "equipmentAverage": 4.15,
            "bathAverage": 3.44,
            "mealAverage": 0
          }
        }
      ]
    },
    {
      "hotel": [
        {
          "hotelBasicInfo": {
            "hotelNo": 5072,
            "hotelName": "天下茶屋",
            "hotelInformationUrl": "http://img.travel.rakuten.co.jp/image/tr/api/kw/JBe8h/?f_no=5072",
            "planListUrl": "http://img.travel.rakuten.co.jp/image/tr/api/kw/3VTwt/?f_no=5072&f_flg=PLAN",
            "dpPlanListUrl": null,
            "reviewUrl": "http://img.travel.rakuten.co.jp/image/tr/api/kw/HTX0u/?f_hotel_no=5072",
            "hotelKanaName": "てんかじゃや",
            "hotelSpecial": "総檜造り、天明檜風呂の秘湯弁天島温泉の割烹旅館",
            "hotelMinCharge": 6480,
            "latitude": 128226.38,
            "longitude": 501144.95,
            "postalCode": "199-0104",
            "address1": "神奈川県",
            "address2": "相模原市緑区千木良1270",
            "telephoneNo": "0426-84-2650",
            "faxNo": "042-684-2225",
            "access": "ＪＲ　相模湖駅下車／中央道相模湖インター１５分／中央道相模湖東出口（東京方面のみ）５分",
            "parkingInformation": "有り　２５台",
            "nearestStation": "相模湖",
            "hotelImageUrl": "http://img.travel.rakuten.co.jp/share/HOTEL/5072/5072.jpg",
            "hotelThumbnailUrl": "http://img.travel.rakuten.co.jp/HIMG/90/5072.jpg",
            "roomImageUrl": "http://img.travel.rakuten.co.jp/share/HOTEL/5072/5072_heya.jpg",
            "roomThumbnailUrl": "http://img.travel.rakuten.co.jp/HIMG/INTERIOR/5072.jpg",
            "hotelMapImageUrl": "http://img.travel.rakuten.co.jp/share/HOTEL/5072/5072map.gif",
            "reviewCount": 115,
            "reviewAverage": 3.1,
            "userReview": null
          }
        },
        {
          "hotelRatingInfo": {
            "serviceAverage": 0,
            "locationAverage": 0,
            "roomAverage": 0,
            "equipmentAverage": 0,
            "bathAverage": 0,
            "mealAverage": 0
          }
        }
      ]
    },
```
  
とりあえず__hotelName__や__planListUrl__（宿泊プランのURL）なんかを使えば良いかなと考えています。



