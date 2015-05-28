module app {
	'use strict';

	export interface IUnitService {
		getAll(): ng.IPromise<IUnit[]>;
	}

	class UnitService implements IUnitService {
		constructor(private $http: ng.IHttpService) {
			//
		}

		getAll(): ng.IPromise<IUnit[]> {
			return this.$http.get<IUnit[]>('/api/units/').then((response) => {
				return response.data;
			});
		}
	}

	function factory($http: ng.IHttpService): IUnitService {
		return new UnitService($http);
	}

	angular.module('app')
		.factory('unitService', factory);
}
