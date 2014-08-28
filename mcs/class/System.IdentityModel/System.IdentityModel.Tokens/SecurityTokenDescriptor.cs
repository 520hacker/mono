﻿//
// SecurityTokenDescriptor.cs
//
// Author:
//   Noesis Labs (Ryan.Melena@noesislabs.com)
//
// Copyright (C) 2014 Noesis Labs, LLC  https://noesislabs.com
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Protocols.WSTrust;
using System.Security.Claims;

namespace System.IdentityModel.Tokens
{
	public class SecurityTokenDescriptor
	{
		private Dictionary<string, Object> properties = new Dictionary<string, object> ();

		public string AppliesToAddress { get; set; }
		public SecurityKeyIdentifierClause AttachedReference { get; set; }
		public AuthenticationInformation AuthenticationInfo { get; set; }
		public EncryptingCredentials EncryptingCredentials { get; set; }
		public Lifetime Lifetime { get; set; }
		public ProofDescriptor Proof { get; set; }
		public Dictionary<string, Object> Properties { get { return properties; } }
		public string ReplyToAddress { get; set; }
		public SigningCredentials SigningCredentials { get; set; }
		public ClaimsIdentity Subject { get; set; }
		public SecurityToken Token { get; set; }
		public string TokenIssuerName { get; set; }
		public string TokenType { get; set; }
		public SecurityKeyIdentifierClause UnattachedReference { get; set; }

		[MonoTODO]
		public void AddAuthenticationClaims (string authType) {
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public void AddAuthenticationClaims (string authType, DateTime time) {
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public virtual void ApplyTo (RequestSecurityTokenResponse response) {
			throw new NotImplementedException ();
		}
	}
}