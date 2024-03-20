﻿using Zaza.Web.DataBase.Entities;

namespace Zaza.Web.Stuff.DTO.Request;

internal record class UserMainDTO(string Login, UserInfo Info, long TelegramId = 0, string Password = "");
internal record class UserLoginRequestDTO(string Login, string Password);