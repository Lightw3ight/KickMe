module app {
	'use strict';

	export interface IProjectService {
		getProjects(): ng.IPromise<IProject[]>;
	}

	class ProjectService implements IProjectService {
		constructor(private $http: ng.IHttpService) {
			//
		}

		getProjects(): ng.IPromise<IProject[]> {
			return this.$http.get<IProject[]>('/api/projects/').then((response) => {
				return response.data;
			});
		}
	}

	function factory($http: ng.IHttpService): IProjectService {
		return new ProjectService($http);
	}

	angular.module('app')
		.factory('projectService', factory);
}
