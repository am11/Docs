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
The routing :doc:`middleware` maps a request to an ``IRouteHandler``. The ``IRouteHandler`` returns a ``RequestDelegate``, or ``null``. If it returns a delegate, that delegate is invoked; otherwise, routing continues. If no route handler is found for a request, then the middleware calls next (and the next middleware in the request pipeline is invoked).

.. TODO in RC2 Middleware later in the request pipeline can access route data using extensions methods on ``HttpContext``.

To get started with using routing in your app, add it to the **dependencies** in ``project.json``:

.. literalinclude:: routing/RoutingSample/project.json
  :linenos:
  :dedent: 4
  :language: javascript
  :lines: 6-12
  :emphasize-lines: 4
  
Next, add it to ``ConfigureServices`` in ``Startup.cs``:

.. literalinclude:: routing/RoutingSample/startup.cs
  :linenos:
  :dedent: 8
  :language: c#
  :lines: 12-16
  :emphasize-lines: 3

.. note:: If you are using ASP.NET MVC, 

Configuring Routing
-------------------


Template Routes
---------------


Link Generation
---------------


