module app {
	'use strict';

	export interface ILocationService {
		getAll(): ng.IPromise<ILocation[]>;
	}

	class LocationService implements ILocationService {
		constructor(private $http: ng.IHttpService) {
			//
		}

		getAll(): ng.IPromise<ILocation[]> {
			return this.$http.get<ILocation[]>('/api/locations/').then((response) => {
				return response.data;
			});
		}
	}

	function factory($http: ng.IHttpService): ILocationService {
		return new LocationService($http);
	}

	angular.module('app')
		.factory('locationService', factory);
}
