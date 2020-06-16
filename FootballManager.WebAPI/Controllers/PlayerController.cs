﻿using FootballManager.Models.Player;
using FootballManagerServices;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FootballManager.WebAPI.Controllers
{
    public class PlayerController : ApiController
    {
        private PlayerService CreatePlayerService()
        {
            //var playerID = Guid.Parse(User.Identity.GetUserId());
            //var playerService = new PlayerService(playerID);
            //return playerService;
            return new PlayerService();
        }
        /// <summary>
        /// Looks up all Players.
        /// </summary>
        public IHttpActionResult Get()
        {
            PlayerService playerService = CreatePlayerService();
            var players = playerService.GetPlayer();
            return Ok(players);
        }
        /// <summary>
        /// Creates a Player with specific information.
        /// </summary>
        public IHttpActionResult Post(CreatePlayer player)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePlayerService();
            if (!service.CreatePlayer(player))
                return InternalServerError();
            return Ok();
        }
        /// <summary>
        /// Looks up a Player by their ID.
        /// </summary>
        public IHttpActionResult Get(int id)
        {
            PlayerService playerService = CreatePlayerService();
            var player = playerService.GetPlayerByID(id);
            return Ok(player);
        }
        /// <summary>
        /// Changes details about a Player.
        /// </summary>
        public IHttpActionResult Put(EditPlayer player)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePlayerService();
            if (!service.UpdatePlayer(player))
                return InternalServerError();
            return Ok();
        }
        /// <summary>
        /// Deletes a Player by their ID.
        /// </summary>
        public IHttpActionResult Delete(int id)
        {
            var service = CreatePlayerService();
            if (!service.DeletePlayer(id))
                return InternalServerError();
            return Ok();
        }
    }
}