﻿namespace Koa.Middleware
{
    using System;

    public interface IMiddlewareStack<TContext>
    {
        Func<TContext, TContext> Compose(params Func<TContext, Func<TContext>, TContext>[] middleware);
    }
}