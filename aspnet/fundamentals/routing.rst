Routing
=======
By `Steve Smith`_

Routing middleware is used to map requests to route handlers. Routes are configured when the application starts up, and can define values that will be passed as parameters to route handlers. Routing functionality is also responsible generating links that correspond to routes in ASP.NET apps.

Sections:
	- `Routing Middleware`_
	- `Configuring Routing`_
	- `Template Routes`_
	- `Link Generation`_

`View sample files <https://github.com/aspnet/Docs/tree/1.0.0-rc1/aspnet/fundamentals/routing/sample>`_

Routing Middleware
------------------
The routing middleware maps a request to an ``IRouteHandler``. The ``IRouteHandler`` returns a ``RequestDelegate``, or ``null``. If it returns a delegate, that delegate is invoked. In the case of ``null``, then routing continues. If not route handler is found for a request, then the middleware simply calls next (and the next middleware in the request pipeline is invoked).

.. TODO in RC2 Middleware later in the request pipeline can access route data using extensions methods on ``HttpContext``.

How to add Routing to an Empty project

Configuring Routing
-------------------


Template Routes
---------------


Link Generation
---------------


