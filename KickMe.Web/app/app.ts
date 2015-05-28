module app {
	'use strict';

	function config($routeProvider: ng.route.IRouteProvider) {
		$routeProvider.when('/home', {
			templateUrl: '/templates/home.html'
		})
			.otherwise({
			redirectTo: '/home'
		});
	}

	angular.module('app',
		[
			'ngRoute',
			'ui.bootstrap.tpls',
			'ui.bootstrap.modal',
			'ui.bootstrap.tpls'
		])
		.config(config);
}
