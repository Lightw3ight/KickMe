module app {
	'use strict';

	export interface ICommentService {
		getByProject(projectId): ng.IPromise<IComment[]>;
		create(comment: string, projectId: number): ng.IPromise<any>;
	}

	class CommentService implements ICommentService {
		baseUrl = '/api/comments/';
		constructor(private $http: ng.IHttpService) {
			//
		}

		getByProject(projectId): ng.IPromise<IComment[]> {
			return this.$http.get<IComment[]>(this.baseUrl + projectId).then((response) => {
				return response.data;
			});
		}

		create(comment: string, projectId: number): ng.IPromise<any> {
			return this.$http.post<void>(this.baseUrl, { description: comment, projectId: projectId }).then((response) => {
				return null;
			});
		}
	}

	function factory($http: ng.IHttpService): ICommentService {
		return new CommentService($http);
	}

	angular.module('app')
		.factory('commentService', factory);
}
