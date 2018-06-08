﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cynthia.Chat.Server.Services;
using Cynthia.Chat.Common.Models;

namespace Cynthia.Chat.Server.Controllers
{
    [Route("api/[controller]")]
    public class ChatController : Controller
    {
        public IDataService ChatData { get; set; }
        public MongoService Mongo { get; set; }
        // GET api/chat 获得数据总数量
        [HttpGet]
        public int GetCount()
        {
            return Mongo.GetDataCount();
        }

        // GET api/chat/5 获得某条之后的所有聊天记录
        [HttpGet("{count}")]
        public IEnumerable<ChatMessage> Get(int count)
        {
            return ChatData.GetData(count);
        }

        // POST api/chat 将一条消息添加进聊天记录
        [HttpPost]
        public void Post([FromBody]ChatMessage data)
        {
            data.Time = DateTime.Now;
            ChatData.AddData(data);
        }

        // PUT api/chat/5 暂时无用
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/chat/5 暂时无用
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
