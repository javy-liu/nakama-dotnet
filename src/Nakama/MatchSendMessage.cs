﻿/**
 * Copyright 2018 The Nakama Authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Nakama
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Send new state to a match on the server.
    /// </summary>
    internal class MatchSendMessage
    {
        [DataMember(Name="match_id")]
        public string MatchId { get; set; }

        [DataMember(Name="op_code")]
        public string OpCode { get; set; }

        [DataMember(Name="presences")]
        public List<UserPresence> Presences { get; set; }

        [DataMember(Name="data")]
        public string State { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            var presences = string.Join(",", Presences);
            return $"MatchSendMessage[MatchId={MatchId}, OpCode={OpCode}, Presences=[{presences}], State={State}]";
        }
    }
}
