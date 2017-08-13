﻿#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2017 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;

namespace MsgPack
{
	/// <summary>
	///		Internal implementation for MessagePack packer.
	/// </summary>
	internal sealed partial class MessagePackPacker<TWriter> : MessagePackPacker
		where TWriter : PackerWriter
	{
		public TWriter Writer { get; private set; }

		public MessagePackPacker( TWriter writer, PackerCompatibilityOptions compatibilityOptions )
			: base( compatibilityOptions )
		{
			this.Writer = writer;
		}

		protected override void Dispose( bool disposing )
		{
			if ( disposing )
			{
				this.Writer.Dispose();
			}

			base.Dispose( disposing );
		}
	}
}
