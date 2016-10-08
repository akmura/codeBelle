class TopController < ApplicationController
  def index
  end
  def entry
    @image_select_option=[["-- 選択して下さい --",0]]
    (1..10).each{|no|
      @image_select_option.push(["画像"+no.to_s,no])
    } 
  end
  def bot

  end
  def results
    # POSTから入力値を受け取る
    no1 = params[:select_no1].to_i
    no2 = params[:select_no2].to_i
    no3 = params[:select_no3].to_i
    @dest_results1 = self.match_by_image(no1)
    @dest_results2 = self.match_by_image(no2)
    @dest_results3 = self.match_by_image(no3)
  end

  def match_by_image(image_no)
    case image_no
    when 1 then "泉岳寺（赤穂浪士の墓）"
    when 2 then "碓氷第三橋梁"
    when 3 then "足尾銅山"
    when 4 then "東京ドームシティ ASOBono！"
    when 5 then "インスタントラーメン博物館"
    when 6 then "ワープステーション江戸"
    when 7 then "釣船茶屋 ざうお"
    when 8 then "犬吠埼"
    when 9 then "巨大迷路パラディアム"
    when 10 then "目黒寄生虫館"
    end
  end
end
