# Commit Rules and Guidelines

This document outlines the commit rules and guidelines to follow when contributing to the Corporation X,Y,Z Notification Service project.

## Commit Message Format

Use the following format for commit messages:

<type>(<scope>): <subject>
  
- `<type>`: Describes the type of the commit (e.g., feat, fix, docs, etc.).
- `<scope>` (optional): Indicates the scope or component affected by the commit.
- `<subject>`: A concise description of the change made in the commit.

Examples:

- `feat(api): Add new SMS endpoint`
- `fix(quota): Reset monthly quotas on the first day of the month`
- `docs(readme): Update API documentation`

## Commit Types

Use the following types for commit messages:

- `feat`: A new feature or enhancement to the system.
- `fix`: A bug fix or error correction.
- `docs`: Documentation-related changes.
- `refactor`: Code refactoring or restructuring that doesn't change functionality.
- `test`: Adding or modifying tests.
- `chore`: Maintenance tasks, build system updates, etc.

## Guidelines

1. Keep each commit focused on a single logical change.
2. Write clear and concise commit messages that describe the purpose of the change.
3. Use present tense in commit messages ("Add feature" instead of "Added feature").
4. Reference relevant issues or pull requests using `#issue-number` or `GH-PR-number`.
5. Always run tests and ensure they pass before committing any changes.
6. Avoid committing commented-out code or temporary debugging statements.
7. If a commit requires additional explanation, provide a more detailed description in the commit body.

## Pull Requests

When creating a pull request, follow these guidelines:

1. Provide a descriptive title for the pull request that summarizes the changes.
2. Reference relevant issues or pull requests using `#issue-number` or `GH-PR-number`.
3. Provide a detailed description of the changes made in the pull request.
4. Assign relevant reviewers for code review.
5. Address any feedback or comments received during the review process.
6. Ensure all tests pass and the code is properly tested before merging the pull request.

## Code Review

During the code review process, consider the following:

1. Provide constructive feedback that helps improve the code quality and maintainability.
2. Ensure the code adheres to the project's coding style and conventions.
3. Verify that the changes meet the defined requirements and fulfill their intended purpose.
4. Identify potential bugs, edge cases, or performance issues and suggest improvements.

## License

By contributing to this project, you agree to license your contributions under the terms of the [MIT License](./LICENSE).
