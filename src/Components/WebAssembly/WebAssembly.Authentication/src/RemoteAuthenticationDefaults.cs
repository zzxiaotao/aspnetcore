// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Components.WebAssembly.Authentication
{
    /// <summary>
    /// Represents default values for different configurable values used across the library.
    /// </summary>
    public class RemoteAuthenticationDefaults
    {
        /// <summary>
        /// The default login path.
        /// </summary>
        public const string LoginPath = "authentication/login";

        /// <summary>
        /// The default login callback path.
        /// </summary>
        public const string LoginCallbackPath = "authentication/login-callback";

        /// <summary>
        /// The default login failed path.
        /// </summary>
        public const string LoginFailedPath = "authentication/login-failed";

        /// <summary>
        /// The default logout path.
        /// </summary>
        public const string LogoutPath = "authentication/logout";

        /// <summary>
        /// The default logout callback path.
        /// </summary>
        public const string LogoutCallbackPath = "authentication/logout-callback";

        /// <summary>
        /// The default logout failed path.
        /// </summary>
        public const string LogoutFailedPath = "authentication/logout-failed";

        /// <summary>
        /// The default logout succeeded path.
        /// </summary>
        public const string LogoutSucceededPath = "authentication/logged-out";

        /// <summary>
        /// The default profile path.
        /// </summary>
        public const string ProfilePath = "authentication/profile";

        /// <summary>
        /// The default register path.
        /// </summary>
        public const string RegisterPath = "authentication/register";
    }
}