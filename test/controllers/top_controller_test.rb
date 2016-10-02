require 'test_helper'

class TopControllerTest < ActionController::TestCase
  test "画像イメージと旅行先の選定ロジック" do
    controller = TopController.new
    output_list =["泉岳寺（赤穂浪士の墓）","碓氷第三橋梁","足尾銅山","東京ドームシティ ASOBono！","インスタントラーメン博物館","ワープステーション江戸","釣船茶屋 ざうお","犬吠埼","巨大迷路パラディアム","目黒寄生虫館"]
    (1..10).each{|input_no|
      assert_equal(output_list[input_no-1],controller.match_by_image(input_no))
    }
  end
end
