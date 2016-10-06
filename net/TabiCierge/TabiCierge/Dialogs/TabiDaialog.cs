using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Newtonsoft.Json;
using System.Threading;
using Microsoft.Bot.Connector;
using System.Collections.Generic;
using TabiCierge.Helpers;

namespace TabiCierge.Dialogs
{
    [Serializable]
    public class TabiDaialog : IDialog
    {
        public int? selectNo1;
        public int? selectNo2;
        public int? selectNo3;

        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
        }

        public async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> argument)
        {
            //挨拶
            await context.PostAsync("こんにちは！旅シェルジュです！貴方の旅行先を、心理学を用いて提案します。 ");
            await context.PostAsync("これから10個の画像を表示します。上から順にお気に入りの画像の番号を回答して下さい。");
            //PromptDialog.Confirm(context,
            //         WillStartAsync,
            //         "診断を希望しますか？(はい/いいえ)");
            //画像を出力
            var activity = (Activity) await argument;
            var reply = activity.CreateReply();
            var attachments = new List<Attachment>
            {
                new Attachment()
            {
                ContentUrl = "http://botscaffold20160927115107.azurewebsites.net/Images/imageSelect.jpg",//グローバル
                ContentType = "image/jpg",
                Name = "診断画像"
            }
            };
            reply.Attachments = attachments;
            await context.PostAsync(reply);
            await context.PostAsync("一番お気に入りの画像を選んで下さい。");
            context.Wait(this.FirstSelectAsync);
        }

        private async Task FirstSelectAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var activity = await result;
            var text = activity.Text;
            int selectNo = 0;
            if (!int.TryParse(text, out selectNo) || selectNo > 10 || selectNo < 0)
            {
                await context.PostAsync("回答は1から10の半角数字で回答して下さい");
                context.Wait(this.FirstSelectAsync);
            }
            else
            {
                selectNo1 = selectNo;
                await context.PostAsync("二番目にお気に入りの画像を選んで下さい。");
                context.Wait(SecondSelectAsync);
            }
        }
        private async Task SecondSelectAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var activity = await result;
            var text = activity.Text;
            int selectNo = 0;
            if (!int.TryParse(text, out selectNo) || selectNo > 10 || selectNo < 0)
            {
                await context.PostAsync("回答は1から10の半角数字で回答して下さい");
                context.Wait(this.SecondSelectAsync);
            }
            else
            {
                selectNo2 = selectNo;
                await context.PostAsync("三番目にお気に入りの画像を選んで下さい。");
                context.Wait(AnserAsync);
            }
        }

        private async Task AnserAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var activity = await result;
            var text = activity.Text;
            int selectNo = 0;
            if (!int.TryParse(text, out selectNo) || selectNo > 10 || selectNo < 0)
            {
                await context.PostAsync("回答は1から10の半角数字で回答して下さい");
                context.Wait(this.AnserAsync);
            }
            else
            {
                selectNo3 = selectNo;
                await context.PostAsync("回答ありがとうございます。貴方におすすめの観光地は");
                Thread.Sleep(1000);
                await context.PostAsync("・");
                Thread.Sleep(1000);
                await context.PostAsync("・");
                Thread.Sleep(1000);
                await context.PostAsync("・");
                Thread.Sleep(1000);
                await context.PostAsync("次の3つとなります。");
                await context.PostAsync("1位　"+ImageSelectHelper.MatchByImage(selectNo1));
                await context.PostAsync("2位　" + ImageSelectHelper.MatchByImage(selectNo2));
                await context.PostAsync("3位　" + ImageSelectHelper.MatchByImage(selectNo3));
                Thread.Sleep(2000);
                await context.PostAsync("如何でしょうか。興味がある観光地がある場合は、教えて下さい。おすすめの宿泊先を楽天トラベルより紹介します。");
                await context.PostAsync("以下未実装");
                context.Done((object)null);
            }
        }
    }
}