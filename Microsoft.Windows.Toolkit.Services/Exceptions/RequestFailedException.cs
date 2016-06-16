﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************
using System;
using System.Net;

namespace Microsoft.Windows.Toolkit.Services.Exceptions
{
    public class RequestFailedException : Exception
    {
        public RequestFailedException()
        {
        }

        public RequestFailedException(string message)
            : base(message)
        {
        }

        [CLSCompliant(false)]
        public RequestFailedException(HttpStatusCode statusCode, string reason)
            : base(string.Format("Request failed with status code {0} and reason '{1}'", (int)statusCode, reason))
        {
        }

        public RequestFailedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
